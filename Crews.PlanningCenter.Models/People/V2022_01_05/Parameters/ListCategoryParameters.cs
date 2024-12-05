namespace Crews.PlanningCenter.Models.People.V2022_01_05.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.ListCategory" />.
/// </summary>
public enum ListCategoryIncludable
{
  /// <summary>
  /// include associated lists
  /// </summary>
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
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
  Name,

  /// <summary>
  /// prefix with a hyphen (-organization_id) to reverse the order
  /// </summary>
  OrganizationId,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
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
  CreatedAt,

  /// <summary>
  /// Query on a specific name
  /// </summary>
  Name,

  /// <summary>
  /// Query on a specific organization_id
  /// </summary>
  OrganizationId,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  UpdatedAt,

}

