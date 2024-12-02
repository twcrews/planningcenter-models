using System.Text.Json;

namespace Crews.PlanningCenter.Models.Calendar.V2018_08_01.Entities;

/// <summary>
/// A conflict between two events caused by overlapping event resource
/// requests.
/// 
/// If the conflict has been resolved, <c>resolved_at</c> will be present.
/// </summary>
public record Conflict
{
  /// <summary>
  /// Unique identifier for the conflict
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// UTC time at which the conflict was created
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Additional information about the conflict or resolution
  /// </summary>
  public string? Note { get; init; }

  /// <summary>
  /// UTC time at which the conflict was resolved
  /// </summary>
  public DateTime? ResolvedAt { get; init; }

  /// <summary>
  /// UTC time at which the conflict was updated
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

}
