using System.Text.Json;

namespace Crews.PlanningCenter.Models.Calendar.V2020_04_08.Entities;

/// <summary>
/// An administrative structure, usually representing a single church.
/// Contains date/time formatting and time zone preferences.
/// </summary>
public record Organization
{
  /// <summary>
  /// Unique identifier for the organization
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// The name of the organization
  /// </summary>
  public string? Name { get; init; }

  /// <summary>
  /// The time zone of the organization
  /// </summary>
  public string? TimeZone { get; init; }

  /// <summary>
  /// - <c>true</c> indicates hours for times will use a 24-hour clock
  /// - <c>false</c> indicates hours for times will use a 12-hour clock
  /// </summary>
  public bool? TwentyFourHourTime { get; init; }

  /// <summary>
  /// Possible values:
  /// - <c>%d/%m/%Y</c>: indicates date/month/year formatting
  /// - <c>%m/%d/%Y</c>: indicates month/date/year formatting
  /// </summary>
  public string? DateFormat { get; init; }

  /// <summary>
  /// Only available when requested with the <c>?fields</c> param
  /// </summary>
  public bool? Onboarding { get; init; }

}
