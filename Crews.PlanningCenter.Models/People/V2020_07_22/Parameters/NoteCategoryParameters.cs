namespace Crews.PlanningCenter.Models.People.V2020_07_22.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.NoteCategory" />.
/// </summary>
public enum NoteCategoryIncludable
{
  /// <summary>
  /// include associated shares
  /// </summary>
  [JsonApiName("shares")]
  Shares,

  /// <summary>
  /// include associated subscribers
  /// </summary>
  [JsonApiName("subscribers")]
  Subscribers,

  /// <summary>
  /// include associated subscriptions
  /// </summary>
  [JsonApiName("subscriptions")]
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
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-locked) to reverse the order
  /// </summary>
  [JsonApiName("locked")]
  Locked,

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
/// Queryable attributes for <see cref="Entities.NoteCategory" />.
/// </summary>
public enum NoteCategoryQueryable
{
  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// Query on a specific locked
  /// </summary>
  [JsonApiName("locked")]
  Locked,

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

/// <summary>
/// Filterable attributes for <see cref="Entities.NoteCategory" />.
/// </summary>
public enum NoteCategoryFilterable
{
  /// <summary>
  /// Filter by view_creatable.
  /// </summary>
  [JsonApiName("view_creatable")]
  ViewCreatable,

}

