namespace Crews.PlanningCenter.Models.Calendar.V2022_07_07.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.ResourceFolder" />.
/// </summary>
public enum ResourceFolderIncludable
{
  /// <summary>
  /// include associated resources
  /// </summary>
  Resources,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.ResourceFolder" />.
/// </summary>
public enum ResourceFolderOrderable
{
  /// <summary>
  /// prefix with a hyphen (-ancestry) to reverse the order
  /// </summary>
  Ancestry,

  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
  Name,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  UpdatedAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.ResourceFolder" />.
/// </summary>
public enum ResourceFolderQueryable
{
  /// <summary>
  /// Query on a specific ancestry
  /// </summary>
  Ancestry,

  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  CreatedAt,

  /// <summary>
  /// Query on a specific name
  /// </summary>
  Name,

  /// <summary>
  /// Query on a specific path_name
  /// </summary>
  PathName,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  UpdatedAt,

}

/// <summary>
/// Filterable attributes for <see cref="Entities.ResourceFolder" />.
/// </summary>
public enum ResourceFolderFilterable
{
  /// <summary>
  /// Filter by resources.
  /// </summary>
  Resources,

  /// <summary>
  /// Filter by rooms.
  /// </summary>
  Rooms,

}

