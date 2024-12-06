namespace Crews.PlanningCenter.Models.Groups.V2023_07_10.Parameters;

/// <summary>
/// Orderable attributes for <see cref="Entities.Resource" />.
/// </summary>
public enum ResourceOrderable
{
  /// <summary>
  /// prefix with a hyphen (-last_updated) to reverse the order
  /// </summary>
  [JsonApiName("last_updated")]
  LastUpdated,

  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
  [JsonApiName("name")]
  Name,

}

