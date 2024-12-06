using System.Text.Json;

namespace Crews.PlanningCenter.Models.Services.V2018_08_01.Entities;

/// <summary>
/// The Folder path of a Service Type
/// </summary>
[JsonApiName("service_type_path")]
public record ServiceTypePath
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("path")]
  public IEnumerable<JsonElement>? Path { get; init; }

}
