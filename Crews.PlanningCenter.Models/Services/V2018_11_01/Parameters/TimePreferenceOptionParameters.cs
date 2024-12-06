namespace Crews.PlanningCenter.Models.Services.V2018_11_01.Parameters;

/// <summary>
/// Orderable attributes for <see cref="Entities.TimePreferenceOption" />.
/// </summary>
public enum TimePreferenceOptionOrderable
{
  /// <summary>
  /// prefix with a hyphen (-day_of_week) to reverse the order
  /// </summary>
  [JsonApiName("day_of_week")]
  DayOfWeek,

  /// <summary>
  /// prefix with a hyphen (-hour_of_day) to reverse the order
  /// </summary>
  [JsonApiName("hour_of_day")]
  HourOfDay,

}

