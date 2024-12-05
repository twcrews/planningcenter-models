namespace Crews.PlanningCenter.Models.CheckIns.V2019_07_17.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.LocationEventTime" />.
/// </summary>
public enum LocationEventTimeIncludable
{
  /// <summary>
  /// include associated event_time
  /// </summary>
  EventTime,

  /// <summary>
  /// include associated location
  /// </summary>
  Location,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.LocationEventTime" />.
/// </summary>
public enum LocationEventTimeQueryable
{
  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  CreatedAt,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  UpdatedAt,

}

