namespace Crews.PlanningCenter.Models.People.V2024_09_12.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Message" />.
/// </summary>
public enum MessageIncludable
{
  /// <summary>
  /// include associated message_group
  /// </summary>
  [JsonApiName("message_group")]
  MessageGroup,

  /// <summary>
  /// include associated to
  /// </summary>
  [JsonApiName("to")]
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
  [JsonApiName("app_name")]
  AppName,

  /// <summary>
  /// prefix with a hyphen (-bounced_at) to reverse the order
  /// </summary>
  [JsonApiName("bounced_at")]
  BouncedAt,

  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-delivery_status) to reverse the order
  /// </summary>
  [JsonApiName("delivery_status")]
  DeliveryStatus,

  /// <summary>
  /// prefix with a hyphen (-file) to reverse the order
  /// </summary>
  [JsonApiName("file")]
  File,

  /// <summary>
  /// prefix with a hyphen (-from_address) to reverse the order
  /// </summary>
  [JsonApiName("from_address")]
  FromAddress,

  /// <summary>
  /// prefix with a hyphen (-from_name) to reverse the order
  /// </summary>
  [JsonApiName("from_name")]
  FromName,

  /// <summary>
  /// prefix with a hyphen (-kind) to reverse the order
  /// </summary>
  [JsonApiName("kind")]
  Kind,

  /// <summary>
  /// prefix with a hyphen (-reject_reason) to reverse the order
  /// </summary>
  [JsonApiName("reject_reason")]
  RejectReason,

  /// <summary>
  /// prefix with a hyphen (-rejection_notification_sent_at) to reverse the order
  /// </summary>
  [JsonApiName("rejection_notification_sent_at")]
  RejectionNotificationSentAt,

  /// <summary>
  /// prefix with a hyphen (-sent_at) to reverse the order
  /// </summary>
  [JsonApiName("sent_at")]
  SentAt,

  /// <summary>
  /// prefix with a hyphen (-subject) to reverse the order
  /// </summary>
  [JsonApiName("subject")]
  Subject,

  /// <summary>
  /// prefix with a hyphen (-to_addresses) to reverse the order
  /// </summary>
  [JsonApiName("to_addresses")]
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
  [JsonApiName("app_name")]
  AppName,

  /// <summary>
  /// Query on a specific bounced_at
  /// </summary>
  [JsonApiName("bounced_at")]
  BouncedAt,

  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// Query on a specific delivery_status
  /// </summary>
  [JsonApiName("delivery_status")]
  DeliveryStatus,

  /// <summary>
  /// Query on a specific file
  /// </summary>
  [JsonApiName("file")]
  File,

  /// <summary>
  /// Query on a specific from_address
  /// </summary>
  [JsonApiName("from_address")]
  FromAddress,

  /// <summary>
  /// Query on a specific kind
  /// 
  /// Possible values: <c>email</c>, <c>sms</c>, or <c>church_center_message</c>
  /// </summary>
  [JsonApiName("kind")]
  Kind,

  /// <summary>
  /// Query on a specific reject_reason
  /// </summary>
  [JsonApiName("reject_reason")]
  RejectReason,

  /// <summary>
  /// Query on a specific rejection_notification_sent_at
  /// </summary>
  [JsonApiName("rejection_notification_sent_at")]
  RejectionNotificationSentAt,

  /// <summary>
  /// Query on a specific sent_at
  /// </summary>
  [JsonApiName("sent_at")]
  SentAt,

  /// <summary>
  /// Query on a specific subject
  /// </summary>
  [JsonApiName("subject")]
  Subject,

  /// <summary>
  /// Query on a specific to_addresses
  /// </summary>
  [JsonApiName("to_addresses")]
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
  [JsonApiName("created_after")]
  CreatedAfter,

}

