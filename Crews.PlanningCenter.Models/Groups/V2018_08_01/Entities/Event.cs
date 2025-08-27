using System.Text.Json;

namespace Crews.PlanningCenter.Models.Groups.V2018_08_01.Entities;

/// <summary>
/// An event is a meeting of a group. It has a start and end time, and can be
/// either physical or virtual.
/// </summary>
[JsonApiName("event")]
public record Event
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// This is a group setting that applies to all the events in the group.
  /// If selected, an email will be sent to the primary email address of the group leader
  /// 60 minutes before the event start time, asking them to report attendance.
  /// </summary>
  [JsonApiName("attendance_requests_enabled")]
  public bool? AttendanceRequestsEnabled { get; init; }

  /// <summary>
  /// If <c>true</c>, we send an event remind some specified time before the event starts
  /// to all members in the group.
  /// </summary>
  [JsonApiName("automated_reminder_enabled")]
  public bool? AutomatedReminderEnabled { get; init; }

  /// <summary>
  /// Whether or not the event has been canceled.
  /// </summary>
  [JsonApiName("canceled")]
  public bool? Canceled { get; init; }

  /// <summary>
  /// The date and time the event was canceled.
  /// </summary>
  [JsonApiName("canceled_at")]
  public DateTime? CanceledAt { get; init; }

  /// <summary>
  /// A longform description of the event. Can contain HTML markup.
  /// </summary>
  [JsonApiName("description")]
  public string? Description { get; init; }

  /// <summary>
  /// The date and time the event ends.
  /// </summary>
  [JsonApiName("ends_at")]
  public DateTime? EndsAt { get; init; }

  /// <summary>
  /// Either "physical" or "virtual".
  /// </summary>
  [JsonApiName("location_type_preference")]
  public string? LocationTypePreference { get; init; }

  /// <summary>
  /// <c>true</c> if the event spans multiple days. Otherwise <c>false</c>.
  /// </summary>
  [JsonApiName("multi_day")]
  public bool? MultiDay { get; init; }

  /// <summary>
  /// The name/title of the event.
  /// </summary>
  [JsonApiName("name")]
  public string? Name { get; init; }

  /// <summary>
  /// <c>true</c> if reminders have been sent for this event. Otherwise <c>false</c>.
  /// </summary>
  [JsonApiName("reminders_sent")]
  public bool? RemindersSent { get; init; }

  /// <summary>
  /// The date and time reminders were sent for this event.
  /// </summary>
  [JsonApiName("reminders_sent_at")]
  public DateTime? RemindersSentAt { get; init; }

  /// <summary>
  /// <c>true</c> if the event is a repeating event. Otherwise <c>false</c>.
  /// </summary>
  [JsonApiName("repeating")]
  public bool? Repeating { get; init; }

  /// <summary>
  /// The date and time the event starts.
  /// </summary>
  [JsonApiName("starts_at")]
  public DateTime? StartsAt { get; init; }

  /// <summary>
  /// The URL for the virtual location. Typically we don't show this URL unless
  /// unless the location_type_preference is "virtual".
  /// </summary>
  [JsonApiName("virtual_location_url")]
  public string? VirtualLocationUrl { get; init; }

  /// <summary>
  /// The number of visitors who attended the event. These are people who are not
  /// members of the group.
  /// </summary>
  [JsonApiName("visitors_count")]
  public int? VisitorsCount { get; init; }

}
