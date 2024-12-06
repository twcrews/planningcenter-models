using System.Text.Json;

namespace Crews.PlanningCenter.Models.Giving.V2019_10_18.Entities;

/// <summary>
/// Planning Center does not provide a description for this resource.
/// </summary>
[JsonApiName("note")]
public record Note
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("body")]
  public string? Body { get; init; }

}
