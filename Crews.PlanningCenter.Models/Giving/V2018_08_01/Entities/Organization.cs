using System.Text.Json;

namespace Crews.PlanningCenter.Models.Giving.V2018_08_01.Entities;

/// <summary>
/// The root level `Organization` record which serves as a link to `Donation`s, `People`, `Fund`s, etc.
/// 
/// </summary>
public record Organization
{
  /// <summary>
  /// The unique identifier for an organization.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// The name for an organization.
  /// </summary>
  public string? Name { get; init; }

  /// <summary>
  /// The time zone for an organization.
  /// </summary>
  public string? TimeZone { get; init; }

}
