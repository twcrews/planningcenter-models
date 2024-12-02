namespace Crews.PlanningCenter.Models.Groups.V2018_08_01.Entities;

/// <summary>
/// The organization represents a single church. Every other resource is scoped to this record.
/// </summary>
public record Organization
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// The name of the organization.
  /// </summary>
  public string? Name { get; init; }

  /// <summary>
  /// The time zone of the organization.
  /// </summary>
  public string? TimeZone { get; init; }

}
