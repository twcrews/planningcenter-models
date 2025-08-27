namespace Crews.PlanningCenter.Models.Giving.V2019_10_18.Parameters;

/// <summary>
/// Queryable attributes for <see cref="Entities.Person" />.
/// </summary>
public enum PersonQueryable
{
  /// <summary>
  /// Query on a specific first_name
  /// </summary>
  [JsonApiName("first_name")]
  FirstName,

  /// <summary>
  /// Query on a specific last_name
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

