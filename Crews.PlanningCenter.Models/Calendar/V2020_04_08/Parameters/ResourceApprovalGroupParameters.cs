namespace Crews.PlanningCenter.Models.Calendar.V2020_04_08.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.ResourceApprovalGroup" />.
/// </summary>
public enum ResourceApprovalGroupIncludable
{
  /// <summary>
  /// include associated people
  /// </summary>
  People,

  /// <summary>
  /// include associated resources
  /// </summary>
  Resources,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.ResourceApprovalGroup" />.
/// </summary>
public enum ResourceApprovalGroupOrderable
{
  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
  Name,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  UpdatedAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.ResourceApprovalGroup" />.
/// </summary>
public enum ResourceApprovalGroupQueryable
{
  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  CreatedAt,

  /// <summary>
  /// Query on a specific name
  /// </summary>
  Name,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  UpdatedAt,

}

