namespace Crews.PlanningCenter.Models.Services.V2018_11_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Folder" />.
/// </summary>
public enum FolderIncludable
{
  /// <summary>
  /// include associated service_types
  /// </summary>
  [JsonApiName("service_types")]
  ServiceTypes,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.Folder" />.
/// </summary>
public enum FolderOrderable
{
  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
  [JsonApiName("name")]
  Name,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Folder" />.
/// </summary>
public enum FolderQueryable
{
  /// <summary>
  /// Query on a related parent
  /// </summary>
  [JsonApiName("parent_id")]
  ParentId,

}

