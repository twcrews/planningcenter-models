using System.Text.Json;

namespace Crews.PlanningCenter.Models.Calendar.V2018_08_01.Entities;

/// <summary>
/// A grouping of tags for organizational purposes.
/// </summary>
public record TagGroup
{
  /// <summary>
  /// Unique identifier for the tag group
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// UTC time at which the tag group was created
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// The name of the tag group
  /// </summary>
  public string? Name { get; init; }

  /// <summary>
  /// UTC time at which the tag group was updated
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// - <c>true</c> indicates tag from this tag group must be applied when creating an event
  /// </summary>
  public bool? Required { get; init; }

}
