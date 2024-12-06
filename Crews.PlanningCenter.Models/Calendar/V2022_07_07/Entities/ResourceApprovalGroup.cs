using System.Text.Json;

namespace Crews.PlanningCenter.Models.Calendar.V2022_07_07.Entities;

/// <summary>
/// A group of people that can be attached to a room or resource
/// in order to require their approval for booking.
/// </summary>
[JsonApiName("resource_approval_group")]
public record ResourceApprovalGroup
{
  /// <summary>
  /// Unique identifier for the approval group
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// UTC time at which the approval group was created
  /// </summary>
  [JsonApiName("created_at")]
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Name of the approval group
  /// </summary>
  [JsonApiName("name")]
  public string? Name { get; init; }

  /// <summary>
  /// UTC time at which the approval group was updated
  /// </summary>
  [JsonApiName("updated_at")]
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// Only available when requested with the <c>?fields</c> param
  /// </summary>
  [JsonApiName("form_count")]
  public int? FormCount { get; init; }

  /// <summary>
  /// The number of resources in the approval group
  /// 
  /// Only available when requested with the <c>?fields</c> param
  /// </summary>
  [JsonApiName("resource_count")]
  public int? ResourceCount { get; init; }

  /// <summary>
  /// The number of rooms in the approval group
  /// 
  /// Only available when requested with the <c>?fields</c> param
  /// </summary>
  [JsonApiName("room_count")]
  public int? RoomCount { get; init; }

}
