using System.Text.Json;

namespace Crews.PlanningCenter.Models.CheckIns.V2023_04_05.Entities;

/// <summary>
/// When one or more people check in, they're grouped in a `CheckInGroup`.
/// These check-ins all have the same "checked-in by" person.
/// 
/// </summary>
public record CheckInGroup
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Id { get; init; }

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
  /// - `ready`: This group isn't printed or canceled yet
  /// - `printed`: This group was successfully printed at a station
  /// - `canceled`: This group was canceled at a station
  /// - `skipped`: This group had no labels to print, so it was never printed.
  /// 
  /// 
  /// Possible values: `not_ready`, `ready`, `printed`, `canceled`, or `skipped`
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
