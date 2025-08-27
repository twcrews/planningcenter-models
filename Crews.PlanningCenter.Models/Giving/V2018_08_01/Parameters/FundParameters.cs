namespace Crews.PlanningCenter.Models.Giving.V2018_08_01.Parameters;

/// <summary>
/// Queryable attributes for <see cref="Entities.Fund" />.
/// </summary>
public enum FundQueryable
{
  /// <summary>
  /// Query on a specific default
  /// </summary>
  [JsonApiName("default")]
  Default,

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

  /// <summary>
  /// Query on a specific visibility
  /// 
  /// Possible values: <c>everywhere</c>, <c>admin_only</c>, <c>nowhere</c>, or <c>hidden</c>
  /// </summary>
  [JsonApiName("visibility")]
  Visibility,

}

