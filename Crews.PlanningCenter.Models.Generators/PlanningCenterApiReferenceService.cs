using System.Text.Json;
using Crews.Extensions.Http;
using Microsoft.Extensions.Options;

namespace Crews.PlanningCenter.Models.Generators;

public class PlanningCenterApiReferenceService
{
	private readonly HttpClient _client;

	private static JsonException NullJsonElementException => new("Unexpected null value in JSON element");
	private static JsonException BadJsonHierarchyException
		=> new("The JSON string is properly formatted, but has an unexpected hierarchy");

	public class Options
	{
		public required Uri BaseAddress { get; set; }
	}

	public static IEnumerable<string> Products =>
 [
		"calendar",
		"check-ins",
		"giving",
		"groups",
		"people",
		"publishing",
		"services"
 ];

	public PlanningCenterApiReferenceService(HttpClient client, IOptions<Options> options)
	{
		_client = client;
		_client.SafelySetBaseAddress(options.Value.BaseAddress);
	}

	public async Task<IEnumerable<string>> GetVersionsAsync(string product)
	{
		HttpResponseMessage response = await _client.GetAsync($"{product}/v2/documentation");
		await using Stream content = await response.Content.ReadAsStreamAsync();
		JsonDocument document = await JsonDocument.ParseAsync(content);

		if (document.RootElement.TryGetProperty("data", out JsonElement dataElement) &&
			dataElement.TryGetProperty("relationships", out JsonElement relationshipsElement) &&
			relationshipsElement.TryGetProperty("versions", out JsonElement versionsElement) &&
			versionsElement.TryGetProperty("data", out JsonElement versionsDataElement))
		{
			List<JsonElement> versionsElements = [.. versionsDataElement.EnumerateArray()];
			return versionsElements.Select(e =>
			{
				if (e.TryGetProperty("id", out JsonElement idElement))
				{
					return idElement.GetString() ?? throw NullJsonElementException;
				}
				throw BadJsonHierarchyException;
			});
		}
		throw BadJsonHierarchyException;
	}

	public async Task<IEnumerable<PlanningCenterResourceInfo>> GetResourcesInfoAsync(string product, string version)
	{
		HttpResponseMessage response = await _client.GetAsync($"{product}/v2/documentation/{version}");
		await using Stream content = await response.Content.ReadAsStreamAsync();
		JsonDocument document = await JsonDocument.ParseAsync(content);

		if (document.RootElement.TryGetProperty("data", out JsonElement dataElement) &&
			dataElement.TryGetProperty("relationships", out JsonElement relationshipsElement) &&
			relationshipsElement.TryGetProperty("vertices", out JsonElement verticesElement) &&
			verticesElement.TryGetProperty("data", out JsonElement verticesDataElement))
		{
			List<JsonElement> verticesElements = [.. verticesDataElement.EnumerateArray()];
			return verticesElements.Select(e =>
			{
				if (e.TryGetProperty("attributes", out JsonElement vertexAttributesElement) &&
					vertexAttributesElement.TryGetProperty("name", out JsonElement nameElement) &&
					e.TryGetProperty("id", out JsonElement idElement))
				{
					JsonElement descriptionElement = vertexAttributesElement.GetProperty("description");
					string description = descriptionElement.GetString() ??
						"Planning Center does not provide a description for this resource.";

					return new PlanningCenterResourceInfo
					{
						ID = idElement.GetString() ?? throw NullJsonElementException,
						Name = nameElement.GetString() ?? throw NullJsonElementException,
						Description = description
					};
				}
				throw BadJsonHierarchyException;
			});
		}
		throw BadJsonHierarchyException;
	}

	public async Task<IEnumerable<PlanningCenterResourceAttributeInfo>> GetAttributesInfoAsync(
		string product, string version, string resource)
	{
		JsonDocument document = await GetResourceDocumentAsync(product, version, resource);

		if (document.RootElement.TryGetProperty("data", out JsonElement data) &&
			data.TryGetProperty("relationships", out JsonElement relationships) &&
			relationships.TryGetProperty("attributes", out JsonElement attributes) &&
			attributes.TryGetProperty("data", out JsonElement attributeData))
		{
			List<JsonElement> attributeElements = [.. attributeData.EnumerateArray()];
			return attributeElements.Select(e =>
			{
				if (e.TryGetProperty("attributes", out JsonElement elementAttributes) &&
					elementAttributes.TryGetProperty("name", out JsonElement nameElement) &&
					elementAttributes.TryGetProperty("type_annotation", out JsonElement typeAnnotation) &&
					typeAnnotation.TryGetProperty("name", out JsonElement typeNameElement))
				{
					JsonElement descriptionElement = elementAttributes.GetProperty("description");
					string description = descriptionElement.GetString() ??
						"Planning Center does not provide a description for this attribute.";

					string name = nameElement.GetString() ?? throw NullJsonElementException;

					return new PlanningCenterResourceAttributeInfo
					{
						Name = name,
						Description = description,
						Type = typeNameElement.GetString() ?? throw NullJsonElementException,
						ClrTypeName = GetClrTypeName(typeNameElement.GetString() ?? throw NullJsonElementException, name)
					};
				}
				throw BadJsonHierarchyException;
			});
		}
		throw BadJsonHierarchyException;
	}

	public Task<IEnumerable<PlanningCenterResourceAttributeInfo>> GetIncludablesInfoAsync(
		string product, string version, string resource)
		=> GetParametersInfoAsync(product, version, resource, "can_include");

	public Task<IEnumerable<PlanningCenterResourceAttributeInfo>> GetOrderablesInfoAsync(
		string product, string version, string resource)
		=> GetParametersInfoAsync(product, version, resource, "can_order");

	public Task<IEnumerable<PlanningCenterResourceAttributeInfo>> GetQueryablesInfoAsync(
		string product, string version, string resource)
		=> GetParametersInfoAsync(product, version, resource, "can_query");

	public async Task<IEnumerable<string>> GetFilterableAttributesAsync(
		string product, string version, string resource)
	{
		JsonDocument document = await GetResourceDocumentAsync(product, version, resource);

		if (document.RootElement.TryGetProperty("data", out JsonElement data) &&
			data.TryGetProperty("relationships", out JsonElement relationships) &&
			relationships.TryGetProperty("inbound_edges", out JsonElement inboundEdgesElement) &&
			inboundEdgesElement.TryGetProperty("data", out JsonElement inboundEdgesDataElement))
		{
			List<JsonElement> filterableAttributesElements = [.. inboundEdgesDataElement.EnumerateArray()];

			JsonElement filterableAttributesElement = filterableAttributesElements
				.SingleOrDefault(e =>
				{
					if (e.TryGetProperty("id", out JsonElement filterableAttributeIdElement))
					{
						return filterableAttributeIdElement.GetString()?.Contains("organization") ?? false;
					}
					throw BadJsonHierarchyException;
				});
			if (filterableAttributesElement.Equals(default(JsonElement))) return [];

			if (filterableAttributesElement.TryGetProperty("attributes", out JsonElement innerAttributesElement) &&
				innerAttributesElement.TryGetProperty("filters", out JsonElement filtersElement))
			{
				IEnumerable<JsonElement> filtersChildElements = filtersElement.EnumerateArray();
				return filtersChildElements.Select(e => e.GetString() ?? throw NullJsonElementException);
			}
			throw BadJsonHierarchyException;
		}
		throw BadJsonHierarchyException;
	}

	private async Task<IEnumerable<PlanningCenterResourceAttributeInfo>> GetParametersInfoAsync(
		string product, string version, string resource, string parameterId)
	{
		IEnumerable<JsonElement> parameterAttributesElements = await
			GetParameterAttributesElementsAsync(product, version, resource, parameterId);
		return parameterAttributesElements.Select(e =>
		{
			if (e.TryGetProperty("name", out JsonElement valueElement) &&
				e.TryGetProperty("type", out JsonElement typeElement))
			{
				JsonElement descriptionElement = e.GetProperty("description");
				string description = descriptionElement.GetString() ??
					"Planning Center does not provide a description for this parameter.";

				string name = valueElement.GetString() ?? throw NullJsonElementException;

				return new PlanningCenterResourceAttributeInfo
				{
					Name = name,
					Description = description,
					Type = typeElement.GetString() ?? throw NullJsonElementException,
					ClrTypeName = GetClrTypeName(typeElement.GetString() ?? throw NullJsonElementException, name)
				};
			}
			throw BadJsonHierarchyException;
		});
	}

	private async Task<JsonDocument> GetResourceDocumentAsync(string product, string version, string resource)
	{
		HttpResponseMessage response = await _client.GetAsync($"{product}/v2/documentation/{version}/vertices/{resource}");
		await using Stream content = await response.Content.ReadAsStreamAsync();
		return await JsonDocument.ParseAsync(content);
	}

	private async Task<IEnumerable<JsonElement>> GetParameterAttributesElementsAsync(
		string product, string version, string resource, string parameterId)
	{
		JsonDocument document = await GetResourceDocumentAsync(product, version, resource);

		if (document.RootElement.TryGetProperty("data", out JsonElement data) &&
			data.TryGetProperty("relationships", out JsonElement relationships) &&
			relationships.TryGetProperty(parameterId, out JsonElement parametersElement) &&
			parametersElement.TryGetProperty("data", out JsonElement parametersDataElement))
		{
			List<JsonElement> parameterElements = [.. parametersDataElement.EnumerateArray()];
			return parameterElements.Select(e =>
			{
				if (e.TryGetProperty("attributes", out JsonElement elementAttributes))
				{
					return elementAttributes;
				}
				throw BadJsonHierarchyException;
			});
		}
		throw BadJsonHierarchyException;
	}

	private static string GetClrTypeName(string typeName, string name)
	{
		// Some Organization object docs incorrectly type the date format attribute as an int.
		if (typeName == "integer" && name == "date_format") return "string";
		return GetClrTypeName(typeName);
	}

	private static string GetClrTypeName(string typeName) => typeName switch
	{
		"string" or "primary_key" or "currency_abbreviation" => "string",
		"date_time" => "DateTime",
		"integer" => "int",
		"boolean" => "bool",
		"float" => "double",
		"array" => "IEnumerable<JsonElement>",
		"date" => "DateOnly",
		_ => "JsonElement",
	};
}
