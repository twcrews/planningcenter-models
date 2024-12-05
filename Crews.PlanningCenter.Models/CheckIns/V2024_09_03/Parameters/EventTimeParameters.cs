namespace Crews.PlanningCenter.Models.CheckIns.V2024_09_03.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.EventTime" />.
/// </summary>
public enum EventTimeIncludable
{
  /// <summary>
  /// include associated event
  /// </summary>
  Event,

  /// <summary>
  /// include associated event_period
  /// </summary>
  EventPeriod,

  /// <summary>
  /// include associated headcounts
  /// </summary>
  Headcounts,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.EventTime" />.
/// </summary>
public enum EventTimeOrderable
{
  /// <summary>
  /// prefix with a hyphen (-shows_at) to reverse the order
  /// </summary>
  ShowsAt,

  /// <summary>
  /// prefix with a hyphen (-starts_at) to reverse the order
  /// </summary>
  StartsAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.EventTime" />.
/// </summary>
public enum EventTimeQueryable
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

