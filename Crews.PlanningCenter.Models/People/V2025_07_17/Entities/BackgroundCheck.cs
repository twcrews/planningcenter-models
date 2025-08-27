using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2025_07_17.Entities;

/// <summary>
/// Background Checks for a Person
/// </summary>
[JsonApiName("background_check")]
public record BackgroundCheck
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("current")]
  public bool? Current { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("note")]
  public string? Note { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("status_updated_at")]
  public DateTime? StatusUpdatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("report_url")]
  public string? ReportUrl { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("expires_on")]
  public DateOnly? ExpiresOn { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("status")]
  public string? Status { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("completed_at")]
  public DateTime? CompletedAt { get; init; }

}
