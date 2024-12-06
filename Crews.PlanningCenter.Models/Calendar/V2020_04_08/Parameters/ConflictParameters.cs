namespace Crews.PlanningCenter.Models.Calendar.V2020_04_08.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Conflict" />.
/// </summary>
public enum ConflictIncludable
{
  /// <summary>
  /// include associated resolved_by
  /// </summary>
  [JsonApiName("resolved_by")]
  ResolvedBy,

  /// <summary>
  /// include associated resource
  /// </summary>
  [JsonApiName("resource")]
  Resource,

  /// <summary>
  /// include associated winner
  /// </summary>
  [JsonApiName("winner")]
  Winner,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.Conflict" />.
/// </summary>
public enum ConflictOrderable
{
  /// <summary>
  /// prefix with a hyphen (-resolved_at) to reverse the order
  /// </summary>
  [JsonApiName("resolved_at")]
  ResolvedAt,

}

/// <summary>
/// Filterable attributes for <see cref="Entities.Conflict" />.
/// </summary>
public enum ConflictFilterable
{
  /// <summary>
  /// Filter by future.
  /// </summary>
  [JsonApiName("future")]
  Future,

  /// <summary>
  /// Filter by resolved.
  /// </summary>
  [JsonApiName("resolved")]
  Resolved,

  /// <summary>
  /// Filter by unresolved.
  /// </summary>
  [JsonApiName("unresolved")]
  Unresolved,

}

