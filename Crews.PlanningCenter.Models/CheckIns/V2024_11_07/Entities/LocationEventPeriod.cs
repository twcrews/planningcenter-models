namespace Crews.PlanningCenter.Models.CheckIns.V2024_11_07.Entities;

/// <summary>
/// Counts check-ins for a location during a certain event period.
/// </summary>
public record LocationEventPeriod
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public int? RegularCount { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public int? GuestCount { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public int? VolunteerCount { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

}
