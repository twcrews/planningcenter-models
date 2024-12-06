namespace Crews.PlanningCenter.Models.CheckIns.V2024_09_03.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.CheckInGroup" />.
/// </summary>
public enum CheckInGroupIncludable
{
  /// <summary>
  /// include associated check_ins
  /// </summary>
  [JsonApiName("check_ins")]
  CheckIns,

  /// <summary>
  /// include associated event_period
  /// </summary>
  [JsonApiName("event_period")]
  EventPeriod,

  /// <summary>
  /// include associated print_station
  /// </summary>
  [JsonApiName("print_station")]
  PrintStation,

}

