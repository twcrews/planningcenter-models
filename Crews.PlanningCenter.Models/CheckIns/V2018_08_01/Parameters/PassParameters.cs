namespace Crews.PlanningCenter.Models.CheckIns.V2018_08_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Pass" />.
/// </summary>
public enum PassIncludable
{
  /// <summary>
  /// include associated person
  /// </summary>
  [JsonApiName("person")]
  Person,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Pass" />.
/// </summary>
public enum PassQueryable
{
  /// <summary>
  /// Query on a specific code
  /// </summary>
  [JsonApiName("code")]
  Code,

}

