namespace Crews.PlanningCenter.Models.Groups.V2023_07_10.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Membership" />.
/// </summary>
public enum MembershipIncludable
{
  /// <summary>
  /// include associated person
  /// </summary>
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
  FirstName,

  /// <summary>
  /// prefix with a hyphen (-joined_at) to reverse the order
  /// </summary>
  JoinedAt,

  /// <summary>
  /// prefix with a hyphen (-last_name) to reverse the order
  /// </summary>
  LastName,

  /// <summary>
  /// prefix with a hyphen (-role) to reverse the order
  /// </summary>
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
  Role,

}

