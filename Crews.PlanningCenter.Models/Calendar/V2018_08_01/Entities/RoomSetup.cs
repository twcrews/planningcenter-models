using System.Text.Json;

namespace Crews.PlanningCenter.Models.Calendar.V2018_08_01.Entities;

/// <summary>
/// A diagram and list of suggested resources useful for predefined room setups.
/// </summary>
public record RoomSetup
{
  /// <summary>
  /// Unique identifier for the room setup
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// UTC time at which the room setup was created
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// The name of the room setup
  /// </summary>
  public string? Name { get; init; }

  /// <summary>
  /// UTC time at which the room setup was updated
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// A description of the room setup
  /// </summary>
  public string? Description { get; init; }

  /// <summary>
  /// An object containing <c>url</c> and <c>thumbnail</c>.
  /// 
  /// <c>url</c> is path to where room setup is stored.
  /// <c>thumbnail</c> contains <c>url</c> path to where thumbnail is stored.
  /// </summary>
  public string? Diagram { get; init; }

  /// <summary>
  /// Path to where room setup is stored
  /// </summary>
  public string? DiagramUrl { get; init; }

  /// <summary>
  /// Path to where thumbnail version of room setup is stored
  /// </summary>
  public string? DiagramThumbnailUrl { get; init; }

}
