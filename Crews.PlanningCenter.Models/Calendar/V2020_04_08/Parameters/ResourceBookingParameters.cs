namespace Crews.PlanningCenter.Models.Calendar.V2020_04_08.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.ResourceBooking" />.
/// </summary>
public enum ResourceBookingIncludable
{
  /// <summary>
  /// include associated event_instance
  /// </summary>
  [JsonApiName("event_instance")]
  EventInstance,

  /// <summary>
  /// include associated event_resource_request
  /// </summary>
  [JsonApiName("event_resource_request")]
  EventResourceRequest,

  /// <summary>
  /// include associated resource
  /// </summary>
  [JsonApiName("resource")]
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
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-ends_at) to reverse the order
  /// </summary>
  [JsonApiName("ends_at")]
  EndsAt,

  /// <summary>
  /// prefix with a hyphen (-starts_at) to reverse the order
  /// </summary>
  [JsonApiName("starts_at")]
  StartsAt,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  [JsonApiName("updated_at")]
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
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// Query on a specific ends_at
  /// </summary>
  [JsonApiName("ends_at")]
  EndsAt,

  /// <summary>
  /// Query on a specific starts_at
  /// </summary>
  [JsonApiName("starts_at")]
  StartsAt,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  [JsonApiName("updated_at")]
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
  [JsonApiName("approved")]
  Approved,

  /// <summary>
  /// Filter by approved_pending.
  /// </summary>
  [JsonApiName("approved_pending")]
  ApprovedPending,

  /// <summary>
  /// Filter by approved_pending_rejected.
  /// </summary>
  [JsonApiName("approved_pending_rejected")]
  ApprovedPendingRejected,

  /// <summary>
  /// Filter by approved_rejected.
  /// </summary>
  [JsonApiName("approved_rejected")]
  ApprovedRejected,

  /// <summary>
  /// Filter by future.
  /// </summary>
  [JsonApiName("future")]
  Future,

  /// <summary>
  /// Filter by pending.
  /// </summary>
  [JsonApiName("pending")]
  Pending,

  /// <summary>
  /// Filter by pending_rejected.
  /// </summary>
  [JsonApiName("pending_rejected")]
  PendingRejected,

  /// <summary>
  /// Filter by rejected.
  /// </summary>
  [JsonApiName("rejected")]
  Rejected,

  /// <summary>
  /// Filter by resources.
  /// </summary>
  [JsonApiName("resources")]
  Resources,

  /// <summary>
  /// Filter by rooms.
  /// </summary>
  [JsonApiName("rooms")]
  Rooms,

}

