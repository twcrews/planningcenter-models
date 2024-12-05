namespace Crews.PlanningCenter.Models.CheckIns.V2019_07_17.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Event" />.
/// </summary>
public enum EventIncludable
{
  /// <summary>
  /// include associated attendance_types
  /// </summary>
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
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
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
  Id,

  /// <summary>
  /// Query on a specific name
  /// </summary>
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
  Archived,

  /// <summary>
  /// Filter by for_headcounts.
  /// </summary>
  ForHeadcounts,

  /// <summary>
  /// Filter by for_registrations.
  /// </summary>
  ForRegistrations,

  /// <summary>
  /// Filter by not_archived.
  /// </summary>
  NotArchived,

}

