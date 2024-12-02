namespace Crews.PlanningCenter.Models.CheckIns.V2024_09_03.Entities;

/// <summary>
/// A tally of attendees for a given event time and attendance type.
/// If one does not exist, the count may have been zero.
/// </summary>
public record Headcount
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public int? Total { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? CreatedAt { get; init; }

}
