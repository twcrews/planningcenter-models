using System.Text.Json;

namespace Crews.PlanningCenter.Models.Services.V2018_08_01.Entities;

/// <summary>
/// An instance of a PlanPerson with included data for displaying in a user's schedule
/// </summary>
[JsonApiName("schedule")]
public record Schedule
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("sort_date")]
  public DateTime? SortDate { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("dates")]
  public string? Dates { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("decline_reason")]
  public string? DeclineReason { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("organization_name")]
  public string? OrganizationName { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("organization_time_zone")]
  public string? OrganizationTimeZone { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("organization_twenty_four_hour_time")]
  public string? OrganizationTwentyFourHourTime { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("person_name")]
  public string? PersonName { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("position_display_times")]
  public string? PositionDisplayTimes { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("responds_to_name")]
  public string? RespondsToName { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("service_type_name")]
  public string? ServiceTypeName { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("short_dates")]
  public string? ShortDates { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("status")]
  public string? Status { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("team_name")]
  public string? TeamName { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("team_position_name")]
  public string? TeamPositionName { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("can_accept_partial")]
  public bool? CanAcceptPartial { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("can_accept_partial_one_time")]
  public bool? CanAcceptPartialOneTime { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("can_rehearse")]
  public bool? CanRehearse { get; init; }

  /// <summary>
  /// True if the scheduled Plan is visible to the scheduled Person
  /// </summary>
  [JsonApiName("plan_visible")]
  public bool? PlanVisible { get; init; }

  /// <summary>
  /// True if the scheduled Plan is visible to the current Person
  /// </summary>
  [JsonApiName("plan_visible_to_me")]
  public bool? PlanVisibleToMe { get; init; }

}
