using System.Text.Json;

namespace Crews.PlanningCenter.Models.Calendar.V2020_04_08.Entities;

/// <summary>
/// A specific occurrence of an event.
/// 
/// If the event is recurring, <c>recurrence</c> will be set and
/// <c>recurrence_description</c> will provide an overview of the recurrence pattern.
/// </summary>
[JsonApiName("event_instance")]
public record EventInstance
{
  /// <summary>
  /// Unique identifier for the event instance
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Indicates whether event instance lasts all day
  /// </summary>
  [JsonApiName("all_day_event")]
  public bool? AllDayEvent { get; init; }

  /// <summary>
  /// UTC time at which the event instance was created
  /// </summary>
  [JsonApiName("created_at")]
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// UTC time at which the event instance ends
  /// </summary>
  [JsonApiName("ends_at")]
  public DateTime? EndsAt { get; init; }

  /// <summary>
  /// Representation of where the event instance takes place
  /// </summary>
  [JsonApiName("location")]
  public string? Location { get; init; }

  /// <summary>
  /// Name of event. Can be overridden for specific instances
  /// </summary>
  [JsonApiName("name")]
  public string? Name { get; init; }

  /// <summary>
  /// For a recurring event instance, the interval of how often the event instance occurs
  /// </summary>
  [JsonApiName("recurrence")]
  public string? Recurrence { get; init; }

  /// <summary>
  /// Longer description of the event instance's recurrence pattern
  /// </summary>
  [JsonApiName("recurrence_description")]
  public string? RecurrenceDescription { get; init; }

  /// <summary>
  /// UTC time at which the event instance starts
  /// </summary>
  [JsonApiName("starts_at")]
  public DateTime? StartsAt { get; init; }

  /// <summary>
  /// UTC time at which the event instance was updated
  /// </summary>
  [JsonApiName("updated_at")]
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// The URL for the event on Church Center
  /// </summary>
  [JsonApiName("church_center_url")]
  public string? ChurchCenterUrl { get; init; }

  /// <summary>
  /// Publicly visible start time
  /// </summary>
  [JsonApiName("published_starts_at")]
  public string? PublishedStartsAt { get; init; }

  /// <summary>
  /// Publicly visible end time
  /// </summary>
  [JsonApiName("published_ends_at")]
  public string? PublishedEndsAt { get; init; }

}
