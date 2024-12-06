namespace Crews.PlanningCenter.Models.People.V2019_10_10.Parameters;

/// <summary>
/// Orderable attributes for <see cref="Entities.NamePrefix" />.
/// </summary>
public enum NamePrefixOrderable
{
  /// <summary>
  /// prefix with a hyphen (-value) to reverse the order
  /// </summary>
  [JsonApiName("value")]
  Value,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.NamePrefix" />.
/// </summary>
public enum NamePrefixQueryable
{
  /// <summary>
  /// Query on a specific value
  /// </summary>
  [JsonApiName("value")]
  Value,

}

