namespace Crews.PlanningCenter.Models.Calendar.V2021_07_20.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Event" />.
/// </summary>
public enum EventIncludable
{
  /// <summary>
  /// include associated attachments
  /// </summary>
  [JsonApiName("attachments")]
  Attachments,

  /// <summary>
  /// include associated feed
  /// </summary>
  [JsonApiName("feed")]
  Feed,

  /// <summary>
  /// include associated owner
  /// </summary>
  [JsonApiName("owner")]
  Owner,

  /// <summary>
  /// include associated tags
  /// </summary>
  [JsonApiName("tags")]
  Tags,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Event" />.
/// </summary>
public enum EventQueryable
{
  /// <summary>
  /// Query on a specific approval_status
  /// </summary>
  [JsonApiName("approval_status")]
  ApprovalStatus,

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
  /// Query on a specific percent_approved
  /// </summary>
  [JsonApiName("percent_approved")]
  PercentApproved,

  /// <summary>
  /// Query on a specific percent_rejected
  /// </summary>
  [JsonApiName("percent_rejected")]
  PercentRejected,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

  /// <summary>
  /// Query on a specific visible_in_church_center
  /// </summary>
  [JsonApiName("visible_in_church_center")]
  VisibleInChurchCenter,

}

/// <summary>
/// Filterable attributes for <see cref="Entities.Event" />.
/// </summary>
public enum EventFilterable
{
  /// <summary>
  /// Filter by future.
  /// </summary>
  [JsonApiName("future")]
  Future,

}

