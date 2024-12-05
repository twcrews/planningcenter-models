namespace Crews.PlanningCenter.Models.People.V2020_04_06.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Message" />.
/// </summary>
public enum MessageIncludable
{
  /// <summary>
  /// include associated message_group
  /// </summary>
  MessageGroup,

  /// <summary>
  /// include associated to
  /// </summary>
  To,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.Message" />.
/// </summary>
public enum MessageOrderable
{
  /// <summary>
  /// prefix with a hyphen (-app_name) to reverse the order
  /// </summary>
  AppName,

  /// <summary>
  /// prefix with a hyphen (-bounced_at) to reverse the order
  /// </summary>
  BouncedAt,

  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-delivery_status) to reverse the order
  /// </summary>
  DeliveryStatus,

  /// <summary>
  /// prefix with a hyphen (-file) to reverse the order
  /// </summary>
  File,

  /// <summary>
  /// prefix with a hyphen (-from_address) to reverse the order
  /// </summary>
  FromAddress,

  /// <summary>
  /// prefix with a hyphen (-from_name) to reverse the order
  /// </summary>
  FromName,

  /// <summary>
  /// prefix with a hyphen (-kind) to reverse the order
  /// </summary>
  Kind,

  /// <summary>
  /// prefix with a hyphen (-reject_reason) to reverse the order
  /// </summary>
  RejectReason,

  /// <summary>
  /// prefix with a hyphen (-rejection_notification_sent_at) to reverse the order
  /// </summary>
  RejectionNotificationSentAt,

  /// <summary>
  /// prefix with a hyphen (-sent_at) to reverse the order
  /// </summary>
  SentAt,

  /// <summary>
  /// prefix with a hyphen (-subject) to reverse the order
  /// </summary>
  Subject,

  /// <summary>
  /// prefix with a hyphen (-to_addresses) to reverse the order
  /// </summary>
  ToAddresses,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Message" />.
/// </summary>
public enum MessageQueryable
{
  /// <summary>
  /// Query on a specific app_name
  /// </summary>
  AppName,

  /// <summary>
  /// Query on a specific bounced_at
  /// </summary>
  BouncedAt,

  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  CreatedAt,

  /// <summary>
  /// Query on a specific delivery_status
  /// </summary>
  DeliveryStatus,

  /// <summary>
  /// Query on a specific file
  /// </summary>
  File,

  /// <summary>
  /// Query on a specific from_address
  /// </summary>
  FromAddress,

  /// <summary>
  /// Query on a specific kind
  /// 
  /// Possible values: <c>email</c>, <c>sms</c>, or <c>church_center_message</c>
  /// </summary>
  Kind,

  /// <summary>
  /// Query on a specific reject_reason
  /// </summary>
  RejectReason,

  /// <summary>
  /// Query on a specific rejection_notification_sent_at
  /// </summary>
  RejectionNotificationSentAt,

  /// <summary>
  /// Query on a specific sent_at
  /// </summary>
  SentAt,

  /// <summary>
  /// Query on a specific subject
  /// </summary>
  Subject,

  /// <summary>
  /// Query on a specific to_addresses
  /// </summary>
  ToAddresses,

}

/// <summary>
/// Filterable attributes for <see cref="Entities.Message" />.
/// </summary>
public enum MessageFilterable
{
  /// <summary>
  /// Filter by created_after.
  /// </summary>
  CreatedAfter,

}

