namespace Crews.PlanningCenter.Models.People.V2019_01_14.Parameters;

/// <summary>
/// Orderable attributes for <see cref="Entities.App" />.
/// </summary>
public enum AppOrderable
{
  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
  [JsonApiName("name")]
  Name,

  /// <summary>
  /// prefix with a hyphen (-url) to reverse the order
  /// </summary>
  [JsonApiName("url")]
  Url,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.App" />.
/// </summary>
public enum AppQueryable
{
  /// <summary>
  /// Query on a specific name
  /// </summary>
  [JsonApiName("name")]
  Name,

  /// <summary>
  /// Query on a specific url
  /// </summary>
  [JsonApiName("url")]
  Url,

}

