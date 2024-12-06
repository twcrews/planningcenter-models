namespace Crews.PlanningCenter.Models.People.V2023_02_15.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.HouseholdMembership" />.
/// </summary>
public enum HouseholdMembershipIncludable
{
  /// <summary>
  /// include associated household
  /// </summary>
  [JsonApiName("household")]
  Household,

  /// <summary>
  /// include associated person
  /// </summary>
  [JsonApiName("person")]
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
  [JsonApiName("pending")]
  Pending,

  /// <summary>
  /// prefix with a hyphen (-person_name) to reverse the order
  /// </summary>
  [JsonApiName("person_name")]
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
  [JsonApiName("pending")]
  Pending,

  /// <summary>
  /// Query on a specific person_name
  /// </summary>
  [JsonApiName("person_name")]
  PersonName,

}

