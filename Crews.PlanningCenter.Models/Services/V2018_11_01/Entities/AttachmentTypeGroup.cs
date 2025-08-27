using System.Text.Json;

namespace Crews.PlanningCenter.Models.Services.V2018_11_01.Entities;

/// <summary>
/// Planning Center does not provide a description for this resource.
/// </summary>
[JsonApiName("attachment_type_group")]
public record AttachmentTypeGroup
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("name")]
  public string? Name { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("readonly")]
  public bool? Readonly { get; init; }

}
