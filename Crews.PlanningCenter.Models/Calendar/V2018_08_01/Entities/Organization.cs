using System.Text.Json;

namespace Crews.PlanningCenter.Models.Calendar.V2018_08_01.Entities;

/// <summary>
/// An administrative structure, usually representing a single church.
/// Contains date/time formatting and time zone preferences.
/// </summary>
[JsonApiName("organization")]
public record Organization
{
  /// <summary>
  /// Unique identifier for the organization
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// The name of the organization
  /// </summary>
  [JsonApiName("name")]
  public string? Name { get; init; }

  /// <summary>
  /// The time zone of the organization
  /// </summary>
  [JsonApiName("time_zone")]
  public string? TimeZone { get; init; }

  /// <summary>
  /// - <c>true</c> indicates hours for times will use a 24-hour clock
  /// - <c>false</c> indicates hours for times will use a 12-hour clock
  /// </summary>
  [JsonApiName("twenty_four_hour_time")]
  public bool? TwentyFourHourTime { get; init; }

  /// <summary>
  /// Possible values:
  /// - <c>%d/%m/%Y</c>: indicates date/month/year formatting
  /// - <c>%m/%d/%Y</c>: indicates month/date/year formatting
  /// </summary>
  [JsonApiName("date_format")]
  public string? DateFormat { get; init; }

  /// <summary>
  /// Only available when requested with the <c>?fields</c> param
  /// </summary>
  [JsonApiName("onboarding")]
  public bool? Onboarding { get; init; }

  /// <summary>
  /// The day of the week the calendar starts on
  /// </summary>
  [JsonApiName("calendar_starts_on")]
  public string? CalendarStartsOn { get; init; }

}
