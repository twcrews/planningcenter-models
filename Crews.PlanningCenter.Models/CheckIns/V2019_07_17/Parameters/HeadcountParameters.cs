namespace Crews.PlanningCenter.Models.CheckIns.V2019_07_17.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Headcount" />.
/// </summary>
public enum HeadcountIncludable
{
  /// <summary>
  /// include associated attendance_type
  /// </summary>
  AttendanceType,

  /// <summary>
  /// include associated event_time
  /// </summary>
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
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-total) to reverse the order
  /// </summary>
  Total,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
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
  CreatedAt,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  UpdatedAt,

}

