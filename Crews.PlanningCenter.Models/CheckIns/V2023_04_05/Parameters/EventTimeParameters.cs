namespace Crews.PlanningCenter.Models.CheckIns.V2023_04_05.Parameters;

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

  /// <summary>
  /// include associated event_period
  /// </summary>
  [JsonApiName("event_period")]
  EventPeriod,

  /// <summary>
  /// include associated headcounts
  /// </summary>
  [JsonApiName("headcounts")]
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
  [JsonApiName("shows_at")]
  ShowsAt,

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
  /// Query on a specific created_at
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

}

