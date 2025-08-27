namespace Crews.PlanningCenter.Models.CheckIns.V2024_11_07.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Event" />.
/// </summary>
public enum EventIncludable
{
  /// <summary>
  /// include associated attendance_types
  /// </summary>
  [JsonApiName("attendance_types")]
  AttendanceTypes,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.Event" />.
/// </summary>
public enum EventOrderable
{
  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
  [JsonApiName("name")]
  Name,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Event" />.
/// </summary>
public enum EventQueryable
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

/// <summary>
/// Filterable attributes for <see cref="Entities.Event" />.
/// </summary>
public enum EventFilterable
{
  /// <summary>
  /// Filter by archived.
  /// </summary>
  [JsonApiName("archived")]
  Archived,

  /// <summary>
  /// Filter by for_campus.
  /// </summary>
  [JsonApiName("for_campus")]
  ForCampus,

  /// <summary>
  /// Filter by for_headcounts.
  /// </summary>
  [JsonApiName("for_headcounts")]
  ForHeadcounts,

  /// <summary>
  /// Filter by for_registrations.
  /// </summary>
  [JsonApiName("for_registrations")]
  ForRegistrations,

  /// <summary>
  /// Filter by not_archived.
  /// </summary>
  [JsonApiName("not_archived")]
  NotArchived,

}

