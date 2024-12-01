using System.Text.Json;

namespace Crews.PlanningCenter.Models.Groups.V2023_07_10.Entities;

/// <summary>
/// An event is a meeting of a group. It has a start and end time, and can be
/// either physical or virtual.
/// 
/// </summary>
public record Event
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// This is a group setting that applies to all the events in the group.
  /// If selected, an email will be sent to the primary email address of the group leader
  /// 10 minutes before the event start time, asking them to report attendance.
  /// 
  /// </summary>
  public bool? AttendanceRequestsEnabled { get; init; }

  /// <summary>
  /// If `true`, we send an event remind some specified time before the event starts
  /// to all members in the group.
  /// 
  /// </summary>
  public bool? AutomatedReminderEnabled { get; init; }

  /// <summary>
  /// Whether or not the event has been canceled.
  /// 
  /// </summary>
  public bool? Canceled { get; init; }

  /// <summary>
  /// The date and time the event was canceled.
  /// 
  /// </summary>
  public DateTime? CanceledAt { get; init; }

  /// <summary>
  /// A longform description of the event. Can contain HTML markup.
  /// 
  /// </summary>
  public string? Description { get; init; }

  /// <summary>
  /// The date and time the event ends.
  /// 
  /// </summary>
  public DateTime? EndsAt { get; init; }

  /// <summary>
  /// Either "physical" or "virtual".
  /// 
  /// </summary>
  public string? LocationTypePreference { get; init; }

  /// <summary>
  /// `true` if the event spans multiple days. Otherwise `false`.
  /// 
  /// </summary>
  public bool? MultiDay { get; init; }

  /// <summary>
  /// The name/title of the event.
  /// 
  /// </summary>
  public string? Name { get; init; }

  /// <summary>
  /// `true` if reminders have been sent for this event. Otherwise `false`.
  /// 
  /// </summary>
  public bool? RemindersSent { get; init; }

  /// <summary>
  /// The date and time reminders were sent for this event.
  /// 
  /// </summary>
  public DateTime? RemindersSentAt { get; init; }

  /// <summary>
  /// `true` if the event is a repeating event. Otherwise `false`.
  /// 
  /// </summary>
  public bool? Repeating { get; init; }

  /// <summary>
  /// The date and time the event starts.
  /// 
  /// </summary>
  public DateTime? StartsAt { get; init; }

  /// <summary>
  /// The URL for the virtual location. Typically we don't show this URL unless
  /// unless the location_type_preference is "virtual".
  /// 
  /// </summary>
  public string? VirtualLocationUrl { get; init; }

  /// <summary>
  /// The number of visitors who attended the event. These are people who are not
  /// members of the group.
  /// 
  /// </summary>
  public int? VisitorsCount { get; init; }

}
