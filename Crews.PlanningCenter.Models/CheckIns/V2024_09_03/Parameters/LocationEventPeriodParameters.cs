namespace Crews.PlanningCenter.Models.CheckIns.V2024_09_03.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.LocationEventPeriod" />.
/// </summary>
public enum LocationEventPeriodIncludable
{
  /// <summary>
  /// include associated event_period
  /// </summary>
  [JsonApiName("event_period")]
  EventPeriod,

  /// <summary>
  /// include associated location
  /// </summary>
  [JsonApiName("location")]
  Location,

}

