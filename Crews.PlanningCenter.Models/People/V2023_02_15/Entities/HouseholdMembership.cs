namespace Crews.PlanningCenter.Models.People.V2023_02_15.Entities;

/// <summary>
/// A household membership is the linking record between a household and a person.
/// </summary>
public record HouseholdMembership
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? PersonName { get; init; }

  /// <summary>
  /// False when a person's memership in a household is unverified.
  /// </summary>
  public bool? Pending { get; init; }

}
