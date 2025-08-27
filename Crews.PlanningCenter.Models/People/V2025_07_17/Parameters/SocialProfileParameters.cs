namespace Crews.PlanningCenter.Models.People.V2025_07_17.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.SocialProfile" />.
/// </summary>
public enum SocialProfileIncludable
{
  /// <summary>
  /// include associated person
  /// </summary>
  [JsonApiName("person")]
  Person,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.SocialProfile" />.
/// </summary>
public enum SocialProfileOrderable
{
  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-site) to reverse the order
  /// </summary>
  [JsonApiName("site")]
  Site,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

  /// <summary>
  /// prefix with a hyphen (-url) to reverse the order
  /// </summary>
  [JsonApiName("url")]
  Url,

  /// <summary>
  /// prefix with a hyphen (-verified) to reverse the order
  /// </summary>
  [JsonApiName("verified")]
  Verified,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.SocialProfile" />.
/// </summary>
public enum SocialProfileQueryable
{
  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// Query on a specific site
  /// </summary>
  [JsonApiName("site")]
  Site,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

  /// <summary>
  /// Query on a specific url
  /// </summary>
  [JsonApiName("url")]
  Url,

  /// <summary>
  /// Query on a specific verified
  /// </summary>
  [JsonApiName("verified")]
  Verified,

}

