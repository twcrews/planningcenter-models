namespace Crews.PlanningCenter.Models.Calendar.V2021_07_20.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.EventInstance" />.
/// </summary>
public enum EventInstanceIncludable
{
  /// <summary>
  /// include associated event
  /// </summary>
  Event,

  /// <summary>
  /// include associated event_times
  /// </summary>
  EventTimes,

  /// <summary>
  /// include associated resource_bookings
  /// </summary>
  ResourceBookings,

  /// <summary>
  /// include associated tags
  /// </summary>
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
/// Queryable attributes for <see cref="Entities.EventInstance" />.
/// </summary>
public enum EventInstanceQueryable
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
/// Filterable attributes for <see cref="Entities.EventInstance" />.
/// </summary>
public enum EventInstanceFilterable
{
  /// <summary>
  /// Filter by all.
  /// </summary>
  All,

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
  /// Filter by approver.
  /// </summary>
  Approver,

  /// <summary>
  /// Filter by approver_subscriber.
  /// </summary>
  ApproverSubscriber,

  /// <summary>
  /// Filter by future.
  /// </summary>
  Future,

  /// <summary>
  /// Filter by lost.
  /// </summary>
  Lost,

  /// <summary>
  /// Filter by manager.
  /// </summary>
  Manager,

  /// <summary>
  /// Filter by manager_approver.
  /// </summary>
  ManagerApprover,

  /// <summary>
  /// Filter by manager_approver_subscriber.
  /// </summary>
  ManagerApproverSubscriber,

  /// <summary>
  /// Filter by manager_subscriber.
  /// </summary>
  ManagerSubscriber,

  /// <summary>
  /// Filter by owner.
  /// </summary>
  Owner,

  /// <summary>
  /// Filter by owner_approver.
  /// </summary>
  OwnerApprover,

  /// <summary>
  /// Filter by owner_approver_subscriber.
  /// </summary>
  OwnerApproverSubscriber,

  /// <summary>
  /// Filter by owner_manager.
  /// </summary>
  OwnerManager,

  /// <summary>
  /// Filter by owner_manager_approver.
  /// </summary>
  OwnerManagerApprover,

  /// <summary>
  /// Filter by owner_manager_approver_subscriber.
  /// </summary>
  OwnerManagerApproverSubscriber,

  /// <summary>
  /// Filter by owner_manager_subscriber.
  /// </summary>
  OwnerManagerSubscriber,

  /// <summary>
  /// Filter by owner_subscriber.
  /// </summary>
  OwnerSubscriber,

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
  /// Filter by shared.
  /// </summary>
  Shared,

  /// <summary>
  /// Filter by subscriber.
  /// </summary>
  Subscriber,

  /// <summary>
  /// Filter by unresolved.
  /// </summary>
  Unresolved,

}

