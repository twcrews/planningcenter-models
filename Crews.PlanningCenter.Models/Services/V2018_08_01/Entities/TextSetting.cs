using System.Text.Json;

namespace Crews.PlanningCenter.Models.Services.V2018_08_01.Entities;

/// <summary>
/// Planning Center does not provide a description for this resource.
/// </summary>
[JsonApiName("text_setting")]
public record TextSetting
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("scheduling_requests_enabled")]
  public bool? SchedulingRequestsEnabled { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("general_emails_enabled")]
  public bool? GeneralEmailsEnabled { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("scheduling_replies_enabled")]
  public bool? SchedulingRepliesEnabled { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("reminders_enabled")]
  public bool? RemindersEnabled { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("carrier")]
  public string? Carrier { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("display_number")]
  public string? DisplayNumber { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("normalized_number")]
  public string? NormalizedNumber { get; init; }

}
