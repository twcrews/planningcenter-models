namespace Crews.PlanningCenter.Models.Groups.V2018_08_01.Parameters;

/// <summary>
/// Orderable attributes for <see cref="Entities.Campus" />.
/// </summary>
public enum CampusOrderable
{
  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
  [JsonApiName("name")]
  Name,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Campus" />.
/// </summary>
public enum CampusQueryable
{
  /// <summary>
  /// Query on a specific id
  /// </summary>
  [JsonApiName("id")]
  Id,

  /// <summary>
  /// Query on a specific name
  /// </summary>
  [JsonApiName("name")]
  Name,

}

