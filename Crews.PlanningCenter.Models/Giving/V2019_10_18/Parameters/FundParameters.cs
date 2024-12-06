namespace Crews.PlanningCenter.Models.Giving.V2019_10_18.Parameters;

/// <summary>
/// Queryable attributes for <see cref="Entities.Fund" />.
/// </summary>
public enum FundQueryable
{
  /// <summary>
  /// query on a specific default
  /// </summary>
  [JsonApiName("default")]
  Default,

  /// <summary>
  /// query on a specific id
  /// </summary>
  [JsonApiName("id")]
  Id,

  /// <summary>
  /// query on a specific name
  /// </summary>
  [JsonApiName("name")]
  Name,

  /// <summary>
  /// query on a specific visibility
  /// </summary>
  [JsonApiName("visibility")]
  Visibility,

}

