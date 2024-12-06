namespace Crews.PlanningCenter.Models.People.V2019_10_10.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Household" />.
/// </summary>
public enum HouseholdIncludable
{
  /// <summary>
  /// include associated people
  /// </summary>
  [JsonApiName("people")]
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
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-member_count) to reverse the order
  /// </summary>
  [JsonApiName("member_count")]
  MemberCount,

  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
  [JsonApiName("name")]
  Name,

  /// <summary>
  /// prefix with a hyphen (-primary_contact_name) to reverse the order
  /// </summary>
  [JsonApiName("primary_contact_name")]
  PrimaryContactName,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  [JsonApiName("updated_at")]
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
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// Query on a specific member_count
  /// </summary>
  [JsonApiName("member_count")]
  MemberCount,

  /// <summary>
  /// Query on a specific name
  /// </summary>
  [JsonApiName("name")]
  Name,

  /// <summary>
  /// Query on a specific primary_contact_name
  /// </summary>
  [JsonApiName("primary_contact_name")]
  PrimaryContactName,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

}

