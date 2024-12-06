namespace Crews.PlanningCenter.Models.Giving.V2018_08_01.Parameters;

/// <summary>
/// Queryable attributes for <see cref="Entities.Person" />.
/// </summary>
public enum PersonQueryable
{
  /// <summary>
  /// query on a specific first_name
  /// </summary>
  [JsonApiName("first_name")]
  FirstName,

  /// <summary>
  /// query on a specific last_name
  /// </summary>
  [JsonApiName("last_name")]
  LastName,

}

/// <summary>
/// Filterable attributes for <see cref="Entities.Person" />.
/// </summary>
public enum PersonFilterable
{
  /// <summary>
  /// Filter by has_donated.
  /// </summary>
  [JsonApiName("has_donated")]
  HasDonated,

}

