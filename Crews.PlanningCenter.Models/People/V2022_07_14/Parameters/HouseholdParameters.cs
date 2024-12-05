namespace Crews.PlanningCenter.Models.People.V2022_07_14.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Household" />.
/// </summary>
public enum HouseholdIncludable
{
  /// <summary>
  /// include associated people
  /// </summary>
  People,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.Household" />.
/// </summary>
public enum HouseholdOrderable
{
  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-member_count) to reverse the order
  /// </summary>
  MemberCount,

  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
  Name,

  /// <summary>
  /// prefix with a hyphen (-primary_contact_name) to reverse the order
  /// </summary>
  PrimaryContactName,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  UpdatedAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Household" />.
/// </summary>
public enum HouseholdQueryable
{
  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  CreatedAt,

  /// <summary>
  /// Query on a specific member_count
  /// </summary>
  MemberCount,

  /// <summary>
  /// Query on a specific name
  /// </summary>
  Name,

  /// <summary>
  /// Query on a specific primary_contact_name
  /// </summary>
  PrimaryContactName,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  UpdatedAt,

}

