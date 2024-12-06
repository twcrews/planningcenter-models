using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2022_01_05.Entities;

/// <summary>
/// Returns upcoming anniversary couples for the organization.
/// </summary>
[JsonApiName("anniversary_couples")]
public record AnniversaryCouples
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

}
