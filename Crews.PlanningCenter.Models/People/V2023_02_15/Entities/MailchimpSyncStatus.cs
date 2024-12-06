using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2023_02_15.Entities;

/// <summary>
/// The status of syncing a List with Mailchimp.
/// </summary>
[JsonApiName("mailchimp_sync_status")]
public record MailchimpSyncStatus
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("status")]
  public string? Status { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("error")]
  public string? Error { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("progress")]
  public int? Progress { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("completed_at")]
  public DateTime? CompletedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("segment_id")]
  public int? SegmentId { get; init; }

}
