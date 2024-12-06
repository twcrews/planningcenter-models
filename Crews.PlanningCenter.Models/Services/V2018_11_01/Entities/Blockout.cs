using System.Text.Json;

namespace Crews.PlanningCenter.Models.Services.V2018_11_01.Entities;

/// <summary>
/// An object representing a blockout date, and an optional recurrence pattern
/// </summary>
[JsonApiName("blockout")]
public record Blockout
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("description")]
  public string? Description { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("group_identifier")]
  public string? GroupIdentifier { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("organization_name")]
  public string? OrganizationName { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("reason")]
  public string? Reason { get; init; }

  /// <summary>
  /// Possible values:
  /// 
  /// - no_repeat
  /// 
  /// - every_1
  /// 
  /// - every_2
  /// 
  /// - every_3
  /// 
  /// - every_4
  /// 
  /// - every_5
  /// 
  /// - every_6
  /// 
  /// - every_7
  /// 
  /// - every_8
  /// </summary>
  [JsonApiName("repeat_frequency")]
  public string? RepeatFrequency { get; init; }

  /// <summary>
  /// Possible values:
  /// 
  /// - exact_day_of_month
  /// 
  /// - week_of_month_1
  /// 
  /// - week_of_month_2
  /// 
  /// - week_of_month_3
  /// 
  /// - week_of_month_4
  /// 
  /// - week_of_month_last
  /// </summary>
  [JsonApiName("repeat_interval")]
  public string? RepeatInterval { get; init; }

  /// <summary>
  /// Possible values:
  /// 
  /// - daily
  /// 
  /// - weekly
  /// 
  /// - monthly
  /// 
  /// - yearly
  /// </summary>
  [JsonApiName("repeat_period")]
  public string? RepeatPeriod { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("settings")]
  public string? Settings { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("time_zone")]
  public string? TimeZone { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("created_at")]
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("updated_at")]
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("repeat_until")]
  public DateOnly? RepeatUntil { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("starts_at")]
  public DateTime? StartsAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("ends_at")]
  public DateTime? EndsAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("share")]
  public bool? Share { get; init; }

}
