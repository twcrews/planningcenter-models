namespace Crews.PlanningCenter.Models.Calendar.V2020_04_08.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Event" />.
/// </summary>
public enum EventIncludable
{
  /// <summary>
  /// include associated attachments
  /// </summary>
  Attachments,

  /// <summary>
  /// include associated feed
  /// </summary>
  Feed,

  /// <summary>
  /// include associated owner
  /// </summary>
  Owner,

  /// <summary>
  /// include associated tags
  /// </summary>
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
  ApprovalStatus,

  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  CreatedAt,

  /// <summary>
  /// Query on a specific name
  /// </summary>
  Name,

  /// <summary>
  /// Query on a specific percent_approved
  /// </summary>
  PercentApproved,

  /// <summary>
  /// Query on a specific percent_rejected
  /// </summary>
  PercentRejected,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  UpdatedAt,

  /// <summary>
  /// Query on a specific visible_in_church_center
  /// </summary>
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
  Future,

}

