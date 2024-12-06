namespace Crews.PlanningCenter.Models.CheckIns.V2024_09_03.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.AttendanceType" />.
/// </summary>
public enum AttendanceTypeIncludable
{
  /// <summary>
  /// include associated event
  /// </summary>
  [JsonApiName("event")]
  Event,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.AttendanceType" />.
/// </summary>
public enum AttendanceTypeQueryable
{
  /// <summary>
  /// Query on a specific id
  /// </summary>
  [JsonApiName("id")]
  Id,

  /// <summary>
  /// Query on a specific name
  /// </summary>
  [JsonApiName("name")]
  Name,

}

