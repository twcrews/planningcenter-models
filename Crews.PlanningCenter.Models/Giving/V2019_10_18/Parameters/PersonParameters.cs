namespace Crews.PlanningCenter.Models.Giving.V2019_10_18.Parameters;

/// <summary>
/// Queryable attributes for <see cref="Entities.Person" />.
/// </summary>
public enum PersonQueryable
{
  /// <summary>
  /// query on a specific first_name
  /// </summary>
  FirstName,

  /// <summary>
  /// query on a specific last_name
  /// </summary>
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
  HasDonated,

}

