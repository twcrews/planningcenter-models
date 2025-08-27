namespace Crews.PlanningCenter.Models.Services.V2018_11_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Schedule" />.
/// </summary>
public enum ScheduleIncludable
{
  /// <summary>
  /// include associated plan_times
  /// </summary>
  [JsonApiName("plan_times")]
  PlanTimes,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.Schedule" />.
/// </summary>
public enum ScheduleOrderable
{
  /// <summary>
  /// prefix with a hyphen (-starts_at) to reverse the order
  /// </summary>
  [JsonApiName("starts_at")]
  StartsAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Schedule" />.
/// </summary>
public enum ScheduleQueryable
{
  /// <summary>
  /// Query on a related plan
  /// </summary>
  [JsonApiName("plan_id")]
  PlanId,

}

