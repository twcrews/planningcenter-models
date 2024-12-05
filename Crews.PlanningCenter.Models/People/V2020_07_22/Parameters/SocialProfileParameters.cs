namespace Crews.PlanningCenter.Models.People.V2020_07_22.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.SocialProfile" />.
/// </summary>
public enum SocialProfileIncludable
{
  /// <summary>
  /// include associated person
  /// </summary>
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
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-site) to reverse the order
  /// </summary>
  Site,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  UpdatedAt,

  /// <summary>
  /// prefix with a hyphen (-url) to reverse the order
  /// </summary>
  Url,

  /// <summary>
  /// prefix with a hyphen (-verified) to reverse the order
  /// </summary>
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
  CreatedAt,

  /// <summary>
  /// Query on a specific site
  /// </summary>
  Site,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  UpdatedAt,

  /// <summary>
  /// Query on a specific url
  /// </summary>
  Url,

  /// <summary>
  /// Query on a specific verified
  /// </summary>
  Verified,

}

