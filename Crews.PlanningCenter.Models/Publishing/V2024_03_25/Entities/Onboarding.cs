using System.Text.Json;

namespace Crews.PlanningCenter.Models.Publishing.V2024_03_25.Entities;

/// <summary>
/// Planning Center does not provide a description for this resource.
/// </summary>
[JsonApiName("onboarding")]
public record Onboarding
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("completed")]
  public bool? Completed { get; init; }

}
