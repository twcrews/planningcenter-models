namespace Crews.PlanningCenter.Models.People.V2020_07_22.Entities;

/// <summary>
/// A martial status represents a member's current status, e.g. married, single, etc.
/// </summary>
public record MaritalStatus
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Value { get; init; }

}
