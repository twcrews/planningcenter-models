namespace Crews.PlanningCenter.Models.People.V2020_07_22.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.WorkflowStep" />.
/// </summary>
public enum WorkflowStepIncludable
{
  /// <summary>
  /// include associated default_assignee
  /// </summary>
  [JsonApiName("default_assignee")]
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
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
  [JsonApiName("name")]
  Name,

  /// <summary>
  /// prefix with a hyphen (-sequence) to reverse the order
  /// </summary>
  [JsonApiName("sequence")]
  Sequence,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  [JsonApiName("updated_at")]
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
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// Query on a specific name
  /// </summary>
  [JsonApiName("name")]
  Name,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

}

