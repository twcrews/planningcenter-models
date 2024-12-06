namespace Crews.PlanningCenter.Models.Services.V2018_11_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Plan" />.
/// </summary>
public enum PlanIncludable
{
  /// <summary>
  /// include associated contributors
  /// </summary>
  [JsonApiName("contributors")]
  Contributors,

  /// <summary>
  /// include associated my_schedules
  /// </summary>
  [JsonApiName("my_schedules")]
  MySchedules,

  /// <summary>
  /// include associated plan_times
  /// </summary>
  [JsonApiName("plan_times")]
  PlanTimes,

  /// <summary>
  /// include associated series
  /// </summary>
  [JsonApiName("series")]
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
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-sort_date) to reverse the order
  /// </summary>
  [JsonApiName("sort_date")]
  SortDate,

  /// <summary>
  /// prefix with a hyphen (-title) to reverse the order
  /// </summary>
  [JsonApiName("title")]
  Title,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  [JsonApiName("updated_at")]
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
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// Query on a specific id
  /// </summary>
  [JsonApiName("id")]
  Id,

  /// <summary>
  /// Query on a specific series_title
  /// </summary>
  [JsonApiName("series_title")]
  SeriesTitle,

  /// <summary>
  /// Query on a specific title
  /// </summary>
  [JsonApiName("title")]
  Title,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

}

