using System.Text.Json;

namespace Crews.PlanningCenter.Models.Calendar.V2021_07_20.Entities;

/// <summary>
/// Start and end times for each event instance.
/// 
/// In the Calendar UI, these are represented under the "Schedule" section and
/// may include "Setup" and "Teardown" times for the instance.
/// 
/// </summary>
public record EventTime
{
  /// <summary>
  /// Unique identifier for the event time
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// UTC time at which the event time ends
  /// </summary>
  public DateTime? EndsAt { get; init; }

  /// <summary>
  /// UTC time at which the event time starts
  /// </summary>
  public DateTime? StartsAt { get; init; }

  /// <summary>
  /// Name of the event time
  /// </summary>
  public DateTime? Name { get; init; }

  /// <summary>
  /// Set to `true` if the time is visible on kiosk
  /// </summary>
  public bool? VisibleOnKiosks { get; init; }

  /// <summary>
  /// Set to `true` if the time is visible on widget or iCal
  /// </summary>
  public bool? VisibleOnWidgetAndIcal { get; init; }

}
