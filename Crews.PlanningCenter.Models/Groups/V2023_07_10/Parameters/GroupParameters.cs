namespace Crews.PlanningCenter.Models.Groups.V2023_07_10.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Group" />.
/// </summary>
public enum GroupIncludable
{
  /// <summary>
  /// include associated enrollment
  /// </summary>
  Enrollment,

  /// <summary>
  /// include associated group_type
  /// </summary>
  GroupType,

  /// <summary>
  /// include associated location
  /// </summary>
  Location,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.Group" />.
/// </summary>
public enum GroupOrderable
{
  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
  Name,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Group" />.
/// </summary>
public enum GroupQueryable
{
  /// <summary>
  /// Query on a specific archive_status
  /// 
  /// Possible values: <c>not_archived</c>, <c>only</c>, or <c>include</c>
  /// </summary>
  ArchiveStatus,

  /// <summary>
  /// Query on a specific name
  /// </summary>
  Name,

}

/// <summary>
/// Filterable attributes for <see cref="Entities.Group" />.
/// </summary>
public enum GroupFilterable
{
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
  /// Filter by people_database_searchable.
  /// </summary>
  PeopleDatabaseSearchable,

}

