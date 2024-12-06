using System.Text.Json;

namespace Crews.PlanningCenter.Models.Calendar.V2021_07_20.Entities;

/// <summary>
/// A diagram and list of suggested resources useful for predefined room setups.
/// </summary>
[JsonApiName("room_setup")]
public record RoomSetup
{
  /// <summary>
  /// Unique identifier for the room setup
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// UTC time at which the room setup was created
  /// </summary>
  [JsonApiName("created_at")]
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// The name of the room setup
  /// </summary>
  [JsonApiName("name")]
  public string? Name { get; init; }

  /// <summary>
  /// UTC time at which the room setup was updated
  /// </summary>
  [JsonApiName("updated_at")]
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// A description of the room setup
  /// </summary>
  [JsonApiName("description")]
  public string? Description { get; init; }

  /// <summary>
  /// An object containing <c>url</c> and <c>thumbnail</c>.
  /// 
  /// <c>url</c> is path to where room setup is stored.
  /// <c>thumbnail</c> contains <c>url</c> path to where thumbnail is stored.
  /// </summary>
  [JsonApiName("diagram")]
  public string? Diagram { get; init; }

  /// <summary>
  /// Path to where room setup is stored
  /// </summary>
  [JsonApiName("diagram_url")]
  public string? DiagramUrl { get; init; }

  /// <summary>
  /// Path to where thumbnail version of room setup is stored
  /// </summary>
  [JsonApiName("diagram_thumbnail_url")]
  public string? DiagramThumbnailUrl { get; init; }

}
