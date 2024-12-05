namespace Crews.PlanningCenter.Models.Services.V2018_08_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Plan" />.
/// </summary>
public enum PlanIncludable
{
  /// <summary>
  /// include associated contributors
  /// </summary>
  Contributors,

  /// <summary>
  /// include associated my_schedules
  /// </summary>
  MySchedules,

  /// <summary>
  /// include associated plan_times
  /// </summary>
  PlanTimes,

  /// <summary>
  /// include associated series
  /// </summary>
  Series,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.Plan" />.
/// </summary>
public enum PlanOrderable
{
  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-sort_date) to reverse the order
  /// </summary>
  SortDate,

  /// <summary>
  /// prefix with a hyphen (-title) to reverse the order
  /// </summary>
  Title,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  UpdatedAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Plan" />.
/// </summary>
public enum PlanQueryable
{
  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  CreatedAt,

  /// <summary>
  /// Query on a specific id
  /// </summary>
  Id,

  /// <summary>
  /// Query on a specific series_title
  /// </summary>
  SeriesTitle,

  /// <summary>
  /// Query on a specific title
  /// </summary>
  Title,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  UpdatedAt,

}

