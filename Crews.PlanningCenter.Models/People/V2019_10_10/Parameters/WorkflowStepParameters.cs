namespace Crews.PlanningCenter.Models.People.V2019_10_10.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.WorkflowStep" />.
/// </summary>
public enum WorkflowStepIncludable
{
  /// <summary>
  /// include associated default_assignee
  /// </summary>
  DefaultAssignee,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.WorkflowStep" />.
/// </summary>
public enum WorkflowStepOrderable
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
  /// prefix with a hyphen (-sequence) to reverse the order
  /// </summary>
  Sequence,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  UpdatedAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.WorkflowStep" />.
/// </summary>
public enum WorkflowStepQueryable
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

