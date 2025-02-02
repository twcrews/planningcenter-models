namespace Crews.PlanningCenter.Models.Services.V2018_08_01.Parameters;

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

