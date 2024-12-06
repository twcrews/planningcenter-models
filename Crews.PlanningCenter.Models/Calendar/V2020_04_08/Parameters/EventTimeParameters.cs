namespace Crews.PlanningCenter.Models.Calendar.V2020_04_08.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.EventTime" />.
/// </summary>
public enum EventTimeIncludable
{
  /// <summary>
  /// include associated event
  /// </summary>
  [JsonApiName("event")]
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
  [JsonApiName("ends_at")]
  EndsAt,

  /// <summary>
  /// prefix with a hyphen (-starts_at) to reverse the order
  /// </summary>
  [JsonApiName("starts_at")]
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
  [JsonApiName("ends_at")]
  EndsAt,

  /// <summary>
  /// Query on a specific name
  /// </summary>
  [JsonApiName("name")]
  Name,

  /// <summary>
  /// Query on a specific starts_at
  /// </summary>
  [JsonApiName("starts_at")]
  StartsAt,

  /// <summary>
  /// Query on a specific visible_on_kiosks
  /// </summary>
  [JsonApiName("visible_on_kiosks")]
  VisibleOnKiosks,

  /// <summary>
  /// Query on a specific visible_on_widget_and_ical
  /// </summary>
  [JsonApiName("visible_on_widget_and_ical")]
  VisibleOnWidgetAndIcal,

}

