namespace Crews.PlanningCenter.Models.People.V2019_10_10.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.ListCategory" />.
/// </summary>
public enum ListCategoryIncludable
{
  /// <summary>
  /// include associated lists
  /// </summary>
  [JsonApiName("lists")]
  Lists,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.ListCategory" />.
/// </summary>
public enum ListCategoryOrderable
{
  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
  [JsonApiName("name")]
  Name,

  /// <summary>
  /// prefix with a hyphen (-organization_id) to reverse the order
  /// </summary>
  [JsonApiName("organization_id")]
  OrganizationId,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.ListCategory" />.
/// </summary>
public enum ListCategoryQueryable
{
  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// Query on a specific name
  /// </summary>
  [JsonApiName("name")]
  Name,

  /// <summary>
  /// Query on a specific organization_id
  /// </summary>
  [JsonApiName("organization_id")]
  OrganizationId,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

}

