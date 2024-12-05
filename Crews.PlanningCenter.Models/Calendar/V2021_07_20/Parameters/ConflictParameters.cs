namespace Crews.PlanningCenter.Models.Calendar.V2021_07_20.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Conflict" />.
/// </summary>
public enum ConflictIncludable
{
  /// <summary>
  /// include associated resolved_by
  /// </summary>
  ResolvedBy,

  /// <summary>
  /// include associated resource
  /// </summary>
  Resource,

  /// <summary>
  /// include associated winner
  /// </summary>
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
  Future,

  /// <summary>
  /// Filter by resolved.
  /// </summary>
  Resolved,

  /// <summary>
  /// Filter by unresolved.
  /// </summary>
  Unresolved,

}

