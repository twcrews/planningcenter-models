using System.Text.Json;

namespace Crews.PlanningCenter.Models.CheckIns.V2019_07_17.Entities;

/// <summary>
/// Counts a person's attendence for a given event.
/// </summary>
public record PersonEvent
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public int? CheckInCount { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? CreatedAt { get; init; }

}
