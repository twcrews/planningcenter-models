using System.Text.Json;

namespace Crews.PlanningCenter.Models.Groups.V2023_07_10.Entities;

/// <summary>
/// The organization represents a single church. Every other resource is scoped to this record.
/// </summary>
[JsonApiName("organization")]
public record Organization
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// The name of the organization.
  /// </summary>
  [JsonApiName("name")]
  public string? Name { get; init; }

  /// <summary>
  /// The time zone of the organization.
  /// </summary>
  [JsonApiName("time_zone")]
  public string? TimeZone { get; init; }

}
