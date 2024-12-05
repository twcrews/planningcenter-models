namespace Crews.PlanningCenter.Models.CheckIns.V2024_09_03.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.EventPeriod" />.
/// </summary>
public enum EventPeriodIncludable
{
  /// <summary>
  /// include associated event
  /// </summary>
  Event,

  /// <summary>
  /// include associated event_times
  /// </summary>
  EventTimes,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.EventPeriod" />.
/// </summary>
public enum EventPeriodOrderable
{
  /// <summary>
  /// prefix with a hyphen (-starts_at) to reverse the order
  /// </summary>
  StartsAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.EventPeriod" />.
/// </summary>
public enum EventPeriodQueryable
{
  /// <summary>
  /// Query on a specific ends_at
  /// </summary>
  EndsAt,

  /// <summary>
  /// Query on a specific starts_at
  /// </summary>
  StartsAt,

}

