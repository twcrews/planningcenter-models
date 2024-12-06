namespace Crews.PlanningCenter.Models.CheckIns.V2024_11_07.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Headcount" />.
/// </summary>
public enum HeadcountIncludable
{
  /// <summary>
  /// include associated attendance_type
  /// </summary>
  [JsonApiName("attendance_type")]
  AttendanceType,

  /// <summary>
  /// include associated event_time
  /// </summary>
  [JsonApiName("event_time")]
  EventTime,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.Headcount" />.
/// </summary>
public enum HeadcountOrderable
{
  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-total) to reverse the order
  /// </summary>
  [JsonApiName("total")]
  Total,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Headcount" />.
/// </summary>
public enum HeadcountQueryable
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

