using System.Text.Json;

namespace Crews.PlanningCenter.Models.Services.V2018_08_01.Entities;

/// <summary>
/// A single plan within a Service Type.
/// </summary>
[JsonApiName("plan")]
public record Plan
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("can_view_order")]
  public bool? CanViewOrder { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("prefers_order_view")]
  public bool? PrefersOrderView { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("rehearsable")]
  public bool? Rehearsable { get; init; }

  /// <summary>
  /// The total number of items, including regular items, songs, media, and headers, that the current user can see in the plan.
  /// </summary>
  [JsonApiName("items_count")]
  public int? ItemsCount { get; init; }

  /// <summary>
  /// The current user's permissions for this plan's Service Type.
  /// </summary>
  [JsonApiName("permissions")]
  public string? Permissions { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("created_at")]
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("title")]
  public string? Title { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("updated_at")]
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// True if Public Access has been enabled.
  /// </summary>
  [JsonApiName("public")]
  public bool? Public { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("series_title")]
  public string? SeriesTitle { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("plan_notes_count")]
  public int? PlanNotesCount { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("other_time_count")]
  public int? OtherTimeCount { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("rehearsal_time_count")]
  public int? RehearsalTimeCount { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("service_time_count")]
  public int? ServiceTimeCount { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("plan_people_count")]
  public int? PlanPeopleCount { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("needed_positions_count")]
  public int? NeededPositionsCount { get; init; }

  /// <summary>
  /// The total of length of all items, excluding pre-service and post-service items.
  /// </summary>
  [JsonApiName("total_length")]
  public int? TotalLength { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("multi_day")]
  public bool? MultiDay { get; init; }

  /// <summary>
  /// A date 15 days after the last service time. ___Returns in the time zone specified in your organization's localization settings___
  /// </summary>
  [JsonApiName("files_expire_at")]
  public DateTime? FilesExpireAt { get; init; }

  /// <summary>
  /// A time representing the chronological first Service Time, used to sort plan chronologically. If no Service Times exist, it uses Rehearsal Times, then Other Times, then NOW. ___Returns in the time zone specified in your organization's localization settings___
  /// </summary>
  [JsonApiName("sort_date")]
  public DateTime? SortDate { get; init; }

  /// <summary>
  /// ___Returns in the time zone specified in your organization's localization settings___
  /// </summary>
  [JsonApiName("last_time_at")]
  public DateTime? LastTimeAt { get; init; }

  /// <summary>
  /// The full date string representing all Service Time dates.
  /// </summary>
  [JsonApiName("dates")]
  public string? Dates { get; init; }

  /// <summary>
  /// The shortened date string representing all Service Time dates. Months are abbreviated, and the year is omitted.
  /// </summary>
  [JsonApiName("short_dates")]
  public string? ShortDates { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("planning_center_url")]
  public string? PlanningCenterUrl { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("reminders_disabled")]
  public bool? RemindersDisabled { get; init; }

}
