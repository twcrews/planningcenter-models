using System.Text.Json;

namespace Crews.PlanningCenter.Models.Calendar.V2022_07_07.Entities;

/// <summary>
/// A room or resource that can be requested for use as part of
/// an event.
/// </summary>
[JsonApiName("resource")]
public record Resource
{
  /// <summary>
  /// Unique identifier for the room or resource
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// UTC time at which the room or resource was created
  /// </summary>
  [JsonApiName("created_at")]
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// The type of resource, can either be <c>Room</c> or <c>Resource</c>
  /// </summary>
  [JsonApiName("kind")]
  public string? Kind { get; init; }

  /// <summary>
  /// The name of the room or resource
  /// </summary>
  [JsonApiName("name")]
  public string? Name { get; init; }

  /// <summary>
  /// The serial number of the resource
  /// </summary>
  [JsonApiName("serial_number")]
  public string? SerialNumber { get; init; }

  /// <summary>
  /// UTC time at which the room or resource was updated
  /// </summary>
  [JsonApiName("updated_at")]
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// Description of the room or resource
  /// </summary>
  [JsonApiName("description")]
  public string? Description { get; init; }

  /// <summary>
  /// UTC time at which the resource expires
  /// </summary>
  [JsonApiName("expires_at")]
  public DateTime? ExpiresAt { get; init; }

  /// <summary>
  /// Where the resource is normally kept
  /// </summary>
  [JsonApiName("home_location")]
  public string? HomeLocation { get; init; }

  /// <summary>
  /// Path to where resource image is stored
  /// </summary>
  [JsonApiName("image")]
  public string? Image { get; init; }

  /// <summary>
  /// The quantity of the resource
  /// </summary>
  [JsonApiName("quantity")]
  public int? Quantity { get; init; }

  /// <summary>
  /// A string representing the location of the resource if it is nested within a folder.
  /// 
  /// Each parent folder is separated by <c>/</c>
  /// </summary>
  [JsonApiName("path_name")]
  public string? PathName { get; init; }

}
