using System.Text.Json;

namespace Crews.PlanningCenter.Models.Calendar.V2022_07_07.Entities;

/// <summary>
/// A group of people that can be attached to a room or resource
/// in order to require their approval for booking.
/// </summary>
public record ResourceApprovalGroup
{
  /// <summary>
  /// Unique identifier for the approval group
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// UTC time at which the approval group was created
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Name of the approval group
  /// </summary>
  public string? Name { get; init; }

  /// <summary>
  /// UTC time at which the approval group was updated
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// Only available when requested with the <c>?fields</c> param
  /// </summary>
  public int? FormCount { get; init; }

  /// <summary>
  /// The number of resources in the approval group
  /// 
  /// Only available when requested with the <c>?fields</c> param
  /// </summary>
  public int? ResourceCount { get; init; }

  /// <summary>
  /// The number of rooms in the approval group
  /// 
  /// Only available when requested with the <c>?fields</c> param
  /// </summary>
  public int? RoomCount { get; init; }

}
