namespace Crews.PlanningCenter.Models.Groups.V2023_07_10.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Event" />.
/// </summary>
public enum EventIncludable
{
  /// <summary>
  /// include associated group
  /// </summary>
  Group,

  /// <summary>
  /// include associated location
  /// </summary>
  Location,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.Event" />.
/// </summary>
public enum EventOrderable
{
  /// <summary>
  /// prefix with a hyphen (-ends_at) to reverse the order
  /// </summary>
  EndsAt,

  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
  Name,

  /// <summary>
  /// prefix with a hyphen (-starts_at) to reverse the order
  /// </summary>
  StartsAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Event" />.
/// </summary>
public enum EventQueryable
{
  /// <summary>
  /// Query on a specific ends_at
  /// </summary>
  EndsAt,

  /// <summary>
  /// Query on a specific name
  /// </summary>
  Name,

  /// <summary>
  /// Query on a specific starts_at
  /// </summary>
  StartsAt,

}

/// <summary>
/// Filterable attributes for <see cref="Entities.Event" />.
/// </summary>
public enum EventFilterable
{
  /// <summary>
  /// Filter by canceled.
  /// </summary>
  Canceled,

  /// <summary>
  /// Filter by group.
  /// </summary>
  Group,

  /// <summary>
  /// Filter by group_type.
  /// </summary>
  GroupType,

  /// <summary>
  /// Filter by my_groups.
  /// </summary>
  MyGroups,

  /// <summary>
  /// Filter by not_canceled.
  /// </summary>
  NotCanceled,

  /// <summary>
  /// Filter by upcoming.
  /// </summary>
  Upcoming,

}

