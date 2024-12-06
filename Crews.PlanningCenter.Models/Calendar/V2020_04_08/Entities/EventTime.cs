using System.Text.Json;

namespace Crews.PlanningCenter.Models.Calendar.V2020_04_08.Entities;

/// <summary>
/// Start and end times for each event instance.
/// 
/// In the Calendar UI, these are represented under the "Schedule" section and
/// may include "Setup" and "Teardown" times for the instance.
/// </summary>
[JsonApiName("event_time")]
public record EventTime
{
  /// <summary>
  /// Unique identifier for the event time
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// UTC time at which the event time ends
  /// </summary>
  [JsonApiName("ends_at")]
  public DateTime? EndsAt { get; init; }

  /// <summary>
  /// UTC time at which the event time starts
  /// </summary>
  [JsonApiName("starts_at")]
  public DateTime? StartsAt { get; init; }

  /// <summary>
  /// Name of the event time
  /// </summary>
  [JsonApiName("name")]
  public DateTime? Name { get; init; }

  /// <summary>
  /// Set to <c>true</c> if the time is visible on kiosk
  /// </summary>
  [JsonApiName("visible_on_kiosks")]
  public bool? VisibleOnKiosks { get; init; }

  /// <summary>
  /// Set to <c>true</c> if the time is visible on widget or iCal
  /// </summary>
  [JsonApiName("visible_on_widget_and_ical")]
  public bool? VisibleOnWidgetAndIcal { get; init; }

}
