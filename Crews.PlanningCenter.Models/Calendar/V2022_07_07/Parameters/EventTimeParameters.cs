namespace Crews.PlanningCenter.Models.Calendar.V2022_07_07.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.EventTime" />.
/// </summary>
public enum EventTimeIncludable
{
  /// <summary>
  /// include associated event
  /// </summary>
  Event,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.EventTime" />.
/// </summary>
public enum EventTimeOrderable
{
  /// <summary>
  /// prefix with a hyphen (-ends_at) to reverse the order
  /// </summary>
  EndsAt,

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
  /// Query on a specific ends_at
  /// </summary>
  EndsAt,

  /// <summary>
  /// Query on a specific name
  /// </summary>
  Name,

  /// <summary>
  /// Query on a specific starts_at
  /// </summary>
  StartsAt,

  /// <summary>
  /// Query on a specific visible_on_kiosks
  /// </summary>
  VisibleOnKiosks,

  /// <summary>
  /// Query on a specific visible_on_widget_and_ical
  /// </summary>
  VisibleOnWidgetAndIcal,

}

