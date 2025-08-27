using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2025_03_20.Entities;

/// <summary>
/// Returns statistics for the organization.
/// </summary>
[JsonApiName("organization_statistics")]
public record OrganizationStatistics
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

}
