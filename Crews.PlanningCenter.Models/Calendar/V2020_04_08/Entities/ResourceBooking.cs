using System.Text.Json;

namespace Crews.PlanningCenter.Models.Calendar.V2020_04_08.Entities;

/// <summary>
/// A specific booking of a room or resource for an event instance.
/// </summary>
[JsonApiName("resource_booking")]
public record ResourceBooking
{
  /// <summary>
  /// Unique identifier for the booking
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// UTC time at which the booking was created
  /// </summary>
  [JsonApiName("created_at")]
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// UTC time at which usage of the booked room or resource ends
  /// </summary>
  [JsonApiName("ends_at")]
  public DateTime? EndsAt { get; init; }

  /// <summary>
  /// UTC time at which usage of the booked room or resource starts
  /// </summary>
  [JsonApiName("starts_at")]
  public DateTime? StartsAt { get; init; }

  /// <summary>
  /// UTC time at which the booking was updated
  /// </summary>
  [JsonApiName("updated_at")]
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// The quantity of the rooms or resources booked
  /// </summary>
  [JsonApiName("quantity")]
  public int? Quantity { get; init; }

}
