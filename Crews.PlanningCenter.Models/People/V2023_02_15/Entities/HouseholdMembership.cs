using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2023_02_15.Entities;

/// <summary>
/// A household membership is the linking record between a household and a person.
/// </summary>
[JsonApiName("household_membership")]
public record HouseholdMembership
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("person_name")]
  public string? PersonName { get; init; }

  /// <summary>
  /// False when a person's memership in a household is unverified.
  /// </summary>
  [JsonApiName("pending")]
  public bool? Pending { get; init; }

}
