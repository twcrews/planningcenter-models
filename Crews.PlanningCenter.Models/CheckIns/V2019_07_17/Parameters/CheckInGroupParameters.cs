namespace Crews.PlanningCenter.Models.CheckIns.V2019_07_17.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.CheckInGroup" />.
/// </summary>
public enum CheckInGroupIncludable
{
  /// <summary>
  /// include associated check_ins
  /// </summary>
  CheckIns,

  /// <summary>
  /// include associated event_period
  /// </summary>
  EventPeriod,

  /// <summary>
  /// include associated print_station
  /// </summary>
  PrintStation,

}

