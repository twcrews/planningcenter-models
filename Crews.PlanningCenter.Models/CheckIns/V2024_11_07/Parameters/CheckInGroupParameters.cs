namespace Crews.PlanningCenter.Models.CheckIns.V2024_11_07.Parameters;

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

