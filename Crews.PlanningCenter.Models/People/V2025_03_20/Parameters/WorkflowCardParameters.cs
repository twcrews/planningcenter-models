namespace Crews.PlanningCenter.Models.People.V2025_03_20.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.WorkflowCard" />.
/// </summary>
public enum WorkflowCardIncludable
{
  /// <summary>
  /// include associated assignee
  /// </summary>
  [JsonApiName("assignee")]
  Assignee,

  /// <summary>
  /// include associated current_step
  /// </summary>
  [JsonApiName("current_step")]
  CurrentStep,

  /// <summary>
  /// include associated person
  /// </summary>
  [JsonApiName("person")]
  Person,

  /// <summary>
  /// include associated workflow
  /// </summary>
  [JsonApiName("workflow")]
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
  [JsonApiName("completed_at")]
  CompletedAt,

  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-first_name) to reverse the order
  /// </summary>
  [JsonApiName("first_name")]
  FirstName,

  /// <summary>
  /// prefix with a hyphen (-flagged_for_notification_at) to reverse the order
  /// </summary>
  [JsonApiName("flagged_for_notification_at")]
  FlaggedForNotificationAt,

  /// <summary>
  /// prefix with a hyphen (-last_name) to reverse the order
  /// </summary>
  [JsonApiName("last_name")]
  LastName,

  /// <summary>
  /// prefix with a hyphen (-moved_to_step_at) to reverse the order
  /// </summary>
  [JsonApiName("moved_to_step_at")]
  MovedToStepAt,

  /// <summary>
  /// prefix with a hyphen (-removed_at) to reverse the order
  /// </summary>
  [JsonApiName("removed_at")]
  RemovedAt,

  /// <summary>
  /// prefix with a hyphen (-stage) to reverse the order
  /// </summary>
  [JsonApiName("stage")]
  Stage,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.WorkflowCard" />.
/// </summary>
public enum WorkflowCardQueryable
{
  /// <summary>
  /// Query on a related assignee
  /// </summary>
  [JsonApiName("assignee_id")]
  AssigneeId,

  /// <summary>
  /// Query on a specific overdue
  /// </summary>
  [JsonApiName("overdue")]
  Overdue,

  /// <summary>
  /// Query on a specific stage
  /// </summary>
  [JsonApiName("stage")]
  Stage,

}

