using System.Text.Json;

namespace Crews.PlanningCenter.Models.Services.V2018_11_01.Entities;

/// <summary>
/// A single plan within a Service Type.
/// </summary>
public record Plan
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public bool? CanViewOrder { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public bool? PrefersOrderView { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public bool? Rehearsable { get; init; }

  /// <summary>
  /// The total number of items, including regular items, songs, media, and headers, that the current user can see in the plan.
  /// </summary>
  public int? ItemsCount { get; init; }

  /// <summary>
  /// The current user's permissions for this plan's Service Type.
  /// </summary>
  public string? Permissions { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Title { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// True if Public Access has been enabled.
  /// </summary>
  public bool? Public { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? SeriesTitle { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public int? PlanNotesCount { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public int? OtherTimeCount { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public int? RehearsalTimeCount { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public int? ServiceTimeCount { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public int? PlanPeopleCount { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public int? NeededPositionsCount { get; init; }

  /// <summary>
  /// The total of length of all items, excluding pre-service and post-service items.
  /// </summary>
  public int? TotalLength { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public bool? MultiDay { get; init; }

  /// <summary>
  /// A date 15 days after the last service time. ___Returns in the time zone specified in your organization's localization settings___
  /// </summary>
  public DateTime? FilesExpireAt { get; init; }

  /// <summary>
  /// A time representing the chronological first Service Time, used to sort plan chronologically. If no Service Times exist, it uses Rehearsal Times, then Other Times, then NOW. ___Returns in the time zone specified in your organization's localization settings___
  /// </summary>
  public DateTime? SortDate { get; init; }

  /// <summary>
  /// ___Returns in the time zone specified in your organization's localization settings___
  /// </summary>
  public DateTime? LastTimeAt { get; init; }

  /// <summary>
  /// The full date string representing all Service Time dates.
  /// </summary>
  public string? Dates { get; init; }

  /// <summary>
  /// The shortened date string representing all Service Time dates. Months are abbreviated, and the year is omitted.
  /// </summary>
  public string? ShortDates { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? PlanningCenterUrl { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public bool? RemindersDisabled { get; init; }

}
