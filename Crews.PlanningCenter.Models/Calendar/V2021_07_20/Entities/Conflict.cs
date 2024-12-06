using System.Text.Json;

namespace Crews.PlanningCenter.Models.Calendar.V2021_07_20.Entities;

/// <summary>
/// A conflict between two events caused by overlapping event resource
/// requests.
/// 
/// If the conflict has been resolved, <c>resolved_at</c> will be present.
/// </summary>
[JsonApiName("conflict")]
public record Conflict
{
  /// <summary>
  /// Unique identifier for the conflict
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// UTC time at which the conflict was created
  /// </summary>
  [JsonApiName("created_at")]
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Additional information about the conflict or resolution
  /// </summary>
  [JsonApiName("note")]
  public string? Note { get; init; }

  /// <summary>
  /// UTC time at which the conflict was resolved
  /// </summary>
  [JsonApiName("resolved_at")]
  public DateTime? ResolvedAt { get; init; }

  /// <summary>
  /// UTC time at which the conflict was updated
  /// </summary>
  [JsonApiName("updated_at")]
  public DateTime? UpdatedAt { get; init; }

}
