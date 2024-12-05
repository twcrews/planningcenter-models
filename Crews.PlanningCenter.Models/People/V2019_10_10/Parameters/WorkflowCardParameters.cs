namespace Crews.PlanningCenter.Models.People.V2019_10_10.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.WorkflowCard" />.
/// </summary>
public enum WorkflowCardIncludable
{
  /// <summary>
  /// include associated assignee
  /// </summary>
  Assignee,

  /// <summary>
  /// include associated current_step
  /// </summary>
  CurrentStep,

  /// <summary>
  /// include associated person
  /// </summary>
  Person,

  /// <summary>
  /// include associated workflow
  /// </summary>
  Workflow,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.WorkflowCard" />.
/// </summary>
public enum WorkflowCardOrderable
{
  /// <summary>
  /// prefix with a hyphen (-completed_at) to reverse the order
  /// </summary>
  CompletedAt,

  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-flagged_for_notification_at) to reverse the order
  /// </summary>
  FlaggedForNotificationAt,

  /// <summary>
  /// prefix with a hyphen (-moved_to_step_at) to reverse the order
  /// </summary>
  MovedToStepAt,

  /// <summary>
  /// prefix with a hyphen (-removed_at) to reverse the order
  /// </summary>
  RemovedAt,

  /// <summary>
  /// prefix with a hyphen (-stage) to reverse the order
  /// </summary>
  Stage,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  UpdatedAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.WorkflowCard" />.
/// </summary>
public enum WorkflowCardQueryable
{
  /// <summary>
  /// Query on a specific overdue
  /// </summary>
  Overdue,

  /// <summary>
  /// Query on a specific stage
  /// </summary>
  Stage,

}

