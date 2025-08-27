namespace Crews.PlanningCenter.Models.Giving.V2019_10_18.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Batch" />.
/// </summary>
public enum BatchIncludable
{
  /// <summary>
  /// include associated batch_group
  /// </summary>
  [JsonApiName("batch_group")]
  BatchGroup,

  /// <summary>
  /// include associated owner
  /// </summary>
  [JsonApiName("owner")]
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
  [JsonApiName("updated_at")]
  UpdatedAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Batch" />.
/// </summary>
public enum BatchQueryable
{
  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  [JsonApiName("updated_at")]
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
  [JsonApiName("committed")]
  Committed,

  /// <summary>
  /// Filter by in_progress.
  /// </summary>
  [JsonApiName("in_progress")]
  InProgress,

}

