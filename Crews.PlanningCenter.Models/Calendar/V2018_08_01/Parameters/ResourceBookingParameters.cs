namespace Crews.PlanningCenter.Models.Calendar.V2018_08_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.ResourceBooking" />.
/// </summary>
public enum ResourceBookingIncludable
{
  /// <summary>
  /// include associated event_instance
  /// </summary>
  EventInstance,

  /// <summary>
  /// include associated event_resource_request
  /// </summary>
  EventResourceRequest,

  /// <summary>
  /// include associated resource
  /// </summary>
  Resource,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.ResourceBooking" />.
/// </summary>
public enum ResourceBookingOrderable
{
  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-ends_at) to reverse the order
  /// </summary>
  EndsAt,

  /// <summary>
  /// prefix with a hyphen (-starts_at) to reverse the order
  /// </summary>
  StartsAt,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  UpdatedAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.ResourceBooking" />.
/// </summary>
public enum ResourceBookingQueryable
{
  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  CreatedAt,

  /// <summary>
  /// Query on a specific ends_at
  /// </summary>
  EndsAt,

  /// <summary>
  /// Query on a specific starts_at
  /// </summary>
  StartsAt,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  UpdatedAt,

}

/// <summary>
/// Filterable attributes for <see cref="Entities.ResourceBooking" />.
/// </summary>
public enum ResourceBookingFilterable
{
  /// <summary>
  /// Filter by approved.
  /// </summary>
  Approved,

  /// <summary>
  /// Filter by approved_pending.
  /// </summary>
  ApprovedPending,

  /// <summary>
  /// Filter by approved_pending_rejected.
  /// </summary>
  ApprovedPendingRejected,

  /// <summary>
  /// Filter by approved_rejected.
  /// </summary>
  ApprovedRejected,

  /// <summary>
  /// Filter by future.
  /// </summary>
  Future,

  /// <summary>
  /// Filter by pending.
  /// </summary>
  Pending,

  /// <summary>
  /// Filter by pending_rejected.
  /// </summary>
  PendingRejected,

  /// <summary>
  /// Filter by rejected.
  /// </summary>
  Rejected,

  /// <summary>
  /// Filter by resources.
  /// </summary>
  Resources,

  /// <summary>
  /// Filter by rooms.
  /// </summary>
  Rooms,

}

