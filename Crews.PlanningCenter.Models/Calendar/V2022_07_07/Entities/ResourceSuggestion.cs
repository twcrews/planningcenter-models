namespace Crews.PlanningCenter.Models.Calendar.V2022_07_07.Entities;

/// <summary>
/// A resource and quantity suggested by a room setup.
/// </summary>
public record ResourceSuggestion
{
  /// <summary>
  /// Unique identifier for the suggestion
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// UTC time at which the suggestion was created
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// How many resources should be requested
  /// </summary>
  public int? Quantity { get; init; }

  /// <summary>
  /// UTC time at which the suggestion was updated
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

}
