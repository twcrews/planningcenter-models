namespace Crews.PlanningCenter.Models.People.V2019_10_10.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.HouseholdMembership" />.
/// </summary>
public enum HouseholdMembershipIncludable
{
  /// <summary>
  /// include associated household
  /// </summary>
  Household,

  /// <summary>
  /// include associated person
  /// </summary>
  Person,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.HouseholdMembership" />.
/// </summary>
public enum HouseholdMembershipOrderable
{
  /// <summary>
  /// prefix with a hyphen (-pending) to reverse the order
  /// </summary>
  Pending,

  /// <summary>
  /// prefix with a hyphen (-person_name) to reverse the order
  /// </summary>
  PersonName,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.HouseholdMembership" />.
/// </summary>
public enum HouseholdMembershipQueryable
{
  /// <summary>
  /// Query on a specific pending
  /// </summary>
  Pending,

  /// <summary>
  /// Query on a specific person_name
  /// </summary>
  PersonName,

}

