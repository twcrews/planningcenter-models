using System.Text.Json;

namespace Crews.PlanningCenter.Models.Calendar.V2018_08_01.Entities;

/// <summary>
/// A specific booking of a room or resource for an event instance.
/// </summary>
public record ResourceBooking
{
  /// <summary>
  /// Unique identifier for the booking
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// UTC time at which the booking was created
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// UTC time at which usage of the booked room or resource ends
  /// </summary>
  public DateTime? EndsAt { get; init; }

  /// <summary>
  /// UTC time at which usage of the booked room or resource starts
  /// </summary>
  public DateTime? StartsAt { get; init; }

  /// <summary>
  /// UTC time at which the booking was updated
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// The quantity of the rooms or resources booked
  /// </summary>
  public int? Quantity { get; init; }

}
