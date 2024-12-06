namespace Crews.PlanningCenter.Models.Groups.V2018_08_01.Parameters;

/// <summary>
/// Orderable attributes for <see cref="Entities.Tag" />.
/// </summary>
public enum TagOrderable
{
  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
  [JsonApiName("name")]
  Name,

  /// <summary>
  /// prefix with a hyphen (-position) to reverse the order
  /// </summary>
  [JsonApiName("position")]
  Position,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Tag" />.
/// </summary>
public enum TagQueryable
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

