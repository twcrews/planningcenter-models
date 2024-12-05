namespace Crews.PlanningCenter.Models.Giving.V2019_10_18.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.BatchGroup" />.
/// </summary>
public enum BatchGroupIncludable
{
  /// <summary>
  /// include associated owner
  /// </summary>
  Owner,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.BatchGroup" />.
/// </summary>
public enum BatchGroupOrderable
{
  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  UpdatedAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.BatchGroup" />.
/// </summary>
public enum BatchGroupQueryable
{
  /// <summary>
  /// query on a specific updated_at
  /// </summary>
  UpdatedAt,

}

/// <summary>
/// Filterable attributes for <see cref="Entities.BatchGroup" />.
/// </summary>
public enum BatchGroupFilterable
{
  /// <summary>
  /// Filter by committed.
  /// </summary>
  Committed,

  /// <summary>
  /// Filter by in_progress.
  /// </summary>
  InProgress,

}

