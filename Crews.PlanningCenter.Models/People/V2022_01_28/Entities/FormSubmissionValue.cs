using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2022_01_28.Entities;

/// <summary>
/// A form submission value.
/// </summary>
[JsonApiName("form_submission_value")]
public record FormSubmissionValue
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("display_value")]
  public string? DisplayValue { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("attachments")]
  public IEnumerable<JsonElement>? Attachments { get; init; }

}
