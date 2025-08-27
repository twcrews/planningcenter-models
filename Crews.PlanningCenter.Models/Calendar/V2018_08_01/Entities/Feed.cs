using System.Text.Json;

namespace Crews.PlanningCenter.Models.Calendar.V2018_08_01.Entities;

/// <summary>
/// A feed belonging to an organization.
/// </summary>
[JsonApiName("feed")]
public record Feed
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("can_delete")]
  public bool? CanDelete { get; init; }

  /// <summary>
  /// Possible values: <c>hidden</c> or <c>published</c>
  /// </summary>
  [JsonApiName("default_church_center_visibility")]
  public string? DefaultChurchCenterVisibility { get; init; }

  /// <summary>
  /// Possible values: <c>registrations</c>, <c>groups</c>, <c>ical</c>, or <c>form</c>
  /// </summary>
  [JsonApiName("feed_type")]
  public string? FeedType { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("imported_at")]
  public DateTime? ImportedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("name")]
  public string? Name { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("deleting")]
  public bool? Deleting { get; init; }

  /// <summary>
  /// Only available when requested with the <c>?fields</c> param
  /// </summary>
  [JsonApiName("sync_campus_tags")]
  public bool? SyncCampusTags { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("source_id")]
  public string? SourceId { get; init; }

}
