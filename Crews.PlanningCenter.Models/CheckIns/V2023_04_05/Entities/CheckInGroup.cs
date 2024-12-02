namespace Crews.PlanningCenter.Models.CheckIns.V2023_04_05.Entities;

/// <summary>
/// When one or more people check in, they're grouped in a <c>CheckInGroup</c>.
/// These check-ins all have the same "checked-in by" person.
/// </summary>
public record CheckInGroup
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public int? NameLabelsCount { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public int? SecurityLabelsCount { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public int? CheckInsCount { get; init; }

  /// <summary>
  /// Possible values:
  /// - <c>ready</c>: This group isn't printed or canceled yet
  /// - <c>printed</c>: This group was successfully printed at a station
  /// - <c>canceled</c>: This group was canceled at a station
  /// - <c>skipped</c>: This group had no labels to print, so it was never printed.
  /// 
  /// Possible values: <c>not_ready</c>, <c>ready</c>, <c>printed</c>, <c>canceled</c>, or <c>skipped</c>
  /// </summary>
  public string? PrintStatus { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

}
