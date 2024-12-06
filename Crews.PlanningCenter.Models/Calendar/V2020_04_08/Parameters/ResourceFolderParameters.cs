namespace Crews.PlanningCenter.Models.Calendar.V2020_04_08.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.ResourceFolder" />.
/// </summary>
public enum ResourceFolderIncludable
{
  /// <summary>
  /// include associated resources
  /// </summary>
  [JsonApiName("resources")]
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
  [JsonApiName("ancestry")]
  Ancestry,

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

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  [JsonApiName("updated_at")]
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
  [JsonApiName("ancestry")]
  Ancestry,

  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// Query on a specific name
  /// </summary>
  [JsonApiName("name")]
  Name,

  /// <summary>
  /// Query on a specific path_name
  /// </summary>
  [JsonApiName("path_name")]
  PathName,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  [JsonApiName("updated_at")]
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
  [JsonApiName("resources")]
  Resources,

  /// <summary>
  /// Filter by rooms.
  /// </summary>
  [JsonApiName("rooms")]
  Rooms,

}

