namespace Crews.PlanningCenter.Models.Groups.V2018_08_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Group" />.
/// </summary>
public enum GroupIncludable
{
  /// <summary>
  /// include associated enrollment
  /// </summary>
  [JsonApiName("enrollment")]
  Enrollment,

  /// <summary>
  /// include associated group_type
  /// </summary>
  [JsonApiName("group_type")]
  GroupType,

  /// <summary>
  /// include associated location
  /// </summary>
  [JsonApiName("location")]
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
  [JsonApiName("name")]
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
  [JsonApiName("archive_status")]
  ArchiveStatus,

  /// <summary>
  /// Query on a specific name
  /// </summary>
  [JsonApiName("name")]
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
  [JsonApiName("group")]
  Group,

  /// <summary>
  /// Filter by group_type.
  /// </summary>
  [JsonApiName("group_type")]
  GroupType,

  /// <summary>
  /// Filter by my_groups.
  /// </summary>
  [JsonApiName("my_groups")]
  MyGroups,

  /// <summary>
  /// Filter by people_database_searchable.
  /// </summary>
  [JsonApiName("people_database_searchable")]
  PeopleDatabaseSearchable,

}

