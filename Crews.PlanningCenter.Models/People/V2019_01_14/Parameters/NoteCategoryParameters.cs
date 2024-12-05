namespace Crews.PlanningCenter.Models.People.V2019_01_14.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.NoteCategory" />.
/// </summary>
public enum NoteCategoryIncludable
{
  /// <summary>
  /// include associated shares
  /// </summary>
  Shares,

  /// <summary>
  /// include associated subscribers
  /// </summary>
  Subscribers,

  /// <summary>
  /// include associated subscriptions
  /// </summary>
  Subscriptions,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.NoteCategory" />.
/// </summary>
public enum NoteCategoryOrderable
{
  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-locked) to reverse the order
  /// </summary>
  Locked,

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
/// Queryable attributes for <see cref="Entities.NoteCategory" />.
/// </summary>
public enum NoteCategoryQueryable
{
  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  CreatedAt,

  /// <summary>
  /// Query on a specific locked
  /// </summary>
  Locked,

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

/// <summary>
/// Filterable attributes for <see cref="Entities.NoteCategory" />.
/// </summary>
public enum NoteCategoryFilterable
{
  /// <summary>
  /// Filter by view_creatable.
  /// </summary>
  ViewCreatable,

}

