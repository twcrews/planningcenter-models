namespace Crews.PlanningCenter.Models.Calendar.V2020_04_08.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.EventResourceRequest" />.
/// </summary>
public enum EventResourceRequestIncludable
{
  /// <summary>
  /// include associated created_by
  /// </summary>
  CreatedBy,

  /// <summary>
  /// include associated event
  /// </summary>
  Event,

  /// <summary>
  /// include associated resource
  /// </summary>
  Resource,

  /// <summary>
  /// include associated room_setup
  /// </summary>
  RoomSetup,

  /// <summary>
  /// include associated updated_by
  /// </summary>
  UpdatedBy,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.EventResourceRequest" />.
/// </summary>
public enum EventResourceRequestQueryable
{
  /// <summary>
  /// Query on a specific approval_sent
  /// </summary>
  ApprovalSent,

  /// <summary>
  /// Query on a specific approval_status
  /// </summary>
  ApprovalStatus,

  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  CreatedAt,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  UpdatedAt,

}

