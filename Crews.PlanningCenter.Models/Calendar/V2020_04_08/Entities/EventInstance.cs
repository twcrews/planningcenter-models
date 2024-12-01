using System.Text.Json;

namespace Crews.PlanningCenter.Models.Calendar.V2020_04_08.Entities;

/// <summary>
/// A specific occurrence of an event.
/// 
/// If the event is recurring, `recurrence` will be set and
/// `recurrence_description` will provide an overview of the recurrence pattern.
/// 
/// </summary>
public record EventInstance
{
  /// <summary>
  /// Unique identifier for the event instance
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// Indicates whether event instance lasts all day
  /// </summary>
  public bool? AllDayEvent { get; init; }

  /// <summary>
  /// UTC time at which the event instance was created
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// UTC time at which the event instance ends
  /// </summary>
  public DateTime? EndsAt { get; init; }

  /// <summary>
  /// Representation of where the event instance takes place
  /// </summary>
  public string? Location { get; init; }

  /// <summary>
  /// For a recurring event instance, the interval of how often the event instance occurs
  /// 
  /// </summary>
  public string? Recurrence { get; init; }

  /// <summary>
  /// Longer description of the event instance's recurrence pattern
  /// 
  /// </summary>
  public string? RecurrenceDescription { get; init; }

  /// <summary>
  /// UTC time at which the event instance starts
  /// </summary>
  public DateTime? StartsAt { get; init; }

  /// <summary>
  /// UTC time at which the event instance was updated
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// The URL for the event on Church Center
  /// </summary>
  public string? ChurchCenterUrl { get; init; }

  /// <summary>
  /// Publicly visible start time
  /// </summary>
  public string? PublishedStartsAt { get; init; }

  /// <summary>
  /// Publicly visible end time
  /// </summary>
  public string? PublishedEndsAt { get; init; }

}
