namespace Crews.PlanningCenter.Models.Groups.V2018_08_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Membership" />.
/// </summary>
public enum MembershipIncludable
{
  /// <summary>
  /// include associated person
  /// </summary>
  [JsonApiName("person")]
  Person,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.Membership" />.
/// </summary>
public enum MembershipOrderable
{
  /// <summary>
  /// prefix with a hyphen (-first_name) to reverse the order
  /// </summary>
  [JsonApiName("first_name")]
  FirstName,

  /// <summary>
  /// prefix with a hyphen (-joined_at) to reverse the order
  /// </summary>
  [JsonApiName("joined_at")]
  JoinedAt,

  /// <summary>
  /// prefix with a hyphen (-last_name) to reverse the order
  /// </summary>
  [JsonApiName("last_name")]
  LastName,

  /// <summary>
  /// prefix with a hyphen (-role) to reverse the order
  /// </summary>
  [JsonApiName("role")]
  Role,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Membership" />.
/// </summary>
public enum MembershipQueryable
{
  /// <summary>
  /// Query on a specific role
  /// </summary>
  [JsonApiName("role")]
  Role,

}

