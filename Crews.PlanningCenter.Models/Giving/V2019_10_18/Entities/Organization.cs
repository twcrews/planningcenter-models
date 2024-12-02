namespace Crews.PlanningCenter.Models.Giving.V2019_10_18.Entities;

/// <summary>
/// The root level <c>Organization</c> record which serves as a link to <c>Donation</c>s, <c>People</c>, <c>Fund</c>s, etc.
/// </summary>
public record Organization
{
  /// <summary>
  /// The unique identifier for an organization.
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// The name for an organization.
  /// </summary>
  public string? Name { get; init; }

  /// <summary>
  /// The time zone for an organization.
  /// </summary>
  public string? TimeZone { get; init; }

}
