namespace Crews.PlanningCenter.Models.Giving.V2019_10_18.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Batch" />.
/// </summary>
public enum BatchIncludable
{
  /// <summary>
  /// include associated batch_group
  /// </summary>
  BatchGroup,

  /// <summary>
  /// include associated owner
  /// </summary>
  Owner,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.Batch" />.
/// </summary>
public enum BatchOrderable
{
  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  UpdatedAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Batch" />.
/// </summary>
public enum BatchQueryable
{
  /// <summary>
  /// query on a specific updated_at
  /// </summary>
  UpdatedAt,

}

/// <summary>
/// Filterable attributes for <see cref="Entities.Batch" />.
/// </summary>
public enum BatchFilterable
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

