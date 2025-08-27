using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2025_07_02.Entities;

/// <summary>
/// A message is an individual email or sms text sent to a member. Every message has a parent message group.
/// </summary>
[JsonApiName("message")]
public record Message
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Possible values: <c>email</c>, <c>sms</c>, or <c>church_center_message</c>
  /// </summary>
  [JsonApiName("kind")]
  public string? Kind { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("to_addresses")]
  public string? ToAddresses { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("subject")]
  public string? Subject { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("delivery_status")]
  public string? DeliveryStatus { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("reject_reason")]
  public string? RejectReason { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("created_at")]
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("sent_at")]
  public DateTime? SentAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("bounced_at")]
  public DateTime? BouncedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("rejection_notification_sent_at")]
  public DateTime? RejectionNotificationSentAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("from_name")]
  public string? FromName { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("from_address")]
  public string? FromAddress { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("read_at")]
  public DateTime? ReadAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("app_name")]
  public string? AppName { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("message_type")]
  public string? MessageType { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("file")]
  public string? File { get; init; }

}
