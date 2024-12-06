using System.Text.Json;

namespace Crews.PlanningCenter.Models.CheckIns.V2018_08_01.Entities;

/// <summary>
/// Counts check-ins for a location for a given event time.
/// This is useful for checking occupancy.
/// </summary>
[JsonApiName("location_event_time")]
public record LocationEventTime
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("regular_count")]
  public int? RegularCount { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("guest_count")]
  public int? GuestCount { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("volunteer_count")]
  public int? VolunteerCount { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("created_at")]
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("updated_at")]
  public DateTime? UpdatedAt { get; init; }

}
