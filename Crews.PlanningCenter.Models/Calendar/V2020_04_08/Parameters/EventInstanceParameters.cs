namespace Crews.PlanningCenter.Models.Calendar.V2020_04_08.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.EventInstance" />.
/// </summary>
public enum EventInstanceIncludable
{
  /// <summary>
  /// include associated event
  /// </summary>
  [JsonApiName("event")]
  Event,

  /// <summary>
  /// include associated event_times
  /// </summary>
  [JsonApiName("event_times")]
  EventTimes,

  /// <summary>
  /// include associated resource_bookings
  /// </summary>
  [JsonApiName("resource_bookings")]
  ResourceBookings,

  /// <summary>
  /// include associated tags
  /// </summary>
  [JsonApiName("tags")]
  Tags,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.EventInstance" />.
/// </summary>
public enum EventInstanceOrderable
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
/// Queryable attributes for <see cref="Entities.EventInstance" />.
/// </summary>
public enum EventInstanceQueryable
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
/// Filterable attributes for <see cref="Entities.EventInstance" />.
/// </summary>
public enum EventInstanceFilterable
{
  /// <summary>
  /// Filter by all.
  /// </summary>
  [JsonApiName("all")]
  All,

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
  /// Filter by approver.
  /// </summary>
  [JsonApiName("approver")]
  Approver,

  /// <summary>
  /// Filter by approver_subscriber.
  /// </summary>
  [JsonApiName("approver_subscriber")]
  ApproverSubscriber,

  /// <summary>
  /// Filter by future.
  /// </summary>
  [JsonApiName("future")]
  Future,

  /// <summary>
  /// Filter by lost.
  /// </summary>
  [JsonApiName("lost")]
  Lost,

  /// <summary>
  /// Filter by manager.
  /// </summary>
  [JsonApiName("manager")]
  Manager,

  /// <summary>
  /// Filter by manager_approver.
  /// </summary>
  [JsonApiName("manager_approver")]
  ManagerApprover,

  /// <summary>
  /// Filter by manager_approver_subscriber.
  /// </summary>
  [JsonApiName("manager_approver_subscriber")]
  ManagerApproverSubscriber,

  /// <summary>
  /// Filter by manager_subscriber.
  /// </summary>
  [JsonApiName("manager_subscriber")]
  ManagerSubscriber,

  /// <summary>
  /// Filter by not_pending_event_requests.
  /// </summary>
  [JsonApiName("not_pending_event_requests")]
  NotPendingEventRequests,

  /// <summary>
  /// Filter by owner.
  /// </summary>
  [JsonApiName("owner")]
  Owner,

  /// <summary>
  /// Filter by owner_approver.
  /// </summary>
  [JsonApiName("owner_approver")]
  OwnerApprover,

  /// <summary>
  /// Filter by owner_approver_subscriber.
  /// </summary>
  [JsonApiName("owner_approver_subscriber")]
  OwnerApproverSubscriber,

  /// <summary>
  /// Filter by owner_manager.
  /// </summary>
  [JsonApiName("owner_manager")]
  OwnerManager,

  /// <summary>
  /// Filter by owner_manager_approver.
  /// </summary>
  [JsonApiName("owner_manager_approver")]
  OwnerManagerApprover,

  /// <summary>
  /// Filter by owner_manager_approver_subscriber.
  /// </summary>
  [JsonApiName("owner_manager_approver_subscriber")]
  OwnerManagerApproverSubscriber,

  /// <summary>
  /// Filter by owner_manager_subscriber.
  /// </summary>
  [JsonApiName("owner_manager_subscriber")]
  OwnerManagerSubscriber,

  /// <summary>
  /// Filter by owner_subscriber.
  /// </summary>
  [JsonApiName("owner_subscriber")]
  OwnerSubscriber,

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
  /// Filter by shared.
  /// </summary>
  [JsonApiName("shared")]
  Shared,

  /// <summary>
  /// Filter by subscriber.
  /// </summary>
  [JsonApiName("subscriber")]
  Subscriber,

  /// <summary>
  /// Filter by unresolved.
  /// </summary>
  [JsonApiName("unresolved")]
  Unresolved,

}

