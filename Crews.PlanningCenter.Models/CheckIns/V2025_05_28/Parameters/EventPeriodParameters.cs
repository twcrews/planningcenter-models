namespace Crews.PlanningCenter.Models.CheckIns.V2025_05_28.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.EventPeriod" />.
/// </summary>
public enum EventPeriodIncludable
{
  /// <summary>
  /// include associated event
  /// </summary>
  [JsonApiName("event")]
  Event,

  /// <summary>
  /// include associated event_times
  /// </summary>
  [JsonApiName("event_times")]
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
  [JsonApiName("starts_at")]
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
  [JsonApiName("ends_at")]
  EndsAt,

  /// <summary>
  /// Query on a specific starts_at
  /// </summary>
  [JsonApiName("starts_at")]
  StartsAt,

}

