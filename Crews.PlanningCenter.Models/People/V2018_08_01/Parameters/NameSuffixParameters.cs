namespace Crews.PlanningCenter.Models.People.V2018_08_01.Parameters;

/// <summary>
/// Orderable attributes for <see cref="Entities.NameSuffix" />.
/// </summary>
public enum NameSuffixOrderable
{
  /// <summary>
  /// prefix with a hyphen (-value) to reverse the order
  /// </summary>
  [JsonApiName("value")]
  Value,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.NameSuffix" />.
/// </summary>
public enum NameSuffixQueryable
{
  /// <summary>
  /// Query on a specific value
  /// </summary>
  [JsonApiName("value")]
  Value,

}

