namespace Crews.PlanningCenter.Models.People.V2019_01_14.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Workflow" />.
/// </summary>
public enum WorkflowIncludable
{
  /// <summary>
  /// include associated category
  /// </summary>
  [JsonApiName("category")]
  Category,

  /// <summary>
  /// include associated shares
  /// </summary>
  [JsonApiName("shares")]
  Shares,

  /// <summary>
  /// include associated steps
  /// </summary>
  [JsonApiName("steps")]
  Steps,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.Workflow" />.
/// </summary>
public enum WorkflowOrderable
{
  /// <summary>
  /// prefix with a hyphen (-campus_id) to reverse the order
  /// </summary>
  [JsonApiName("campus_id")]
  CampusId,

  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-deleted_at) to reverse the order
  /// </summary>
  [JsonApiName("deleted_at")]
  DeletedAt,

  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
  [JsonApiName("name")]
  Name,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

  /// <summary>
  /// prefix with a hyphen (-workflow_category_id) to reverse the order
  /// </summary>
  [JsonApiName("workflow_category_id")]
  WorkflowCategoryId,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Workflow" />.
/// </summary>
public enum WorkflowQueryable
{
  /// <summary>
  /// Query on a specific campus_id
  /// </summary>
  [JsonApiName("campus_id")]
  CampusId,

  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// Query on a specific deleted_at
  /// </summary>
  [JsonApiName("deleted_at")]
  DeletedAt,

  /// <summary>
  /// Query on a specific id
  /// </summary>
  [JsonApiName("id")]
  Id,

  /// <summary>
  /// Query on a specific name
  /// </summary>
  [JsonApiName("name")]
  Name,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

  /// <summary>
  /// Query on a specific workflow_category_id
  /// </summary>
  [JsonApiName("workflow_category_id")]
  WorkflowCategoryId,

}

/// <summary>
/// Filterable attributes for <see cref="Entities.Workflow" />.
/// </summary>
public enum WorkflowFilterable
{
  /// <summary>
  /// Filter by has_my_cards.
  /// </summary>
  [JsonApiName("has_my_cards")]
  HasMyCards,

  /// <summary>
  /// Filter by manage_cards_allowed.
  /// </summary>
  [JsonApiName("manage_cards_allowed")]
  ManageCardsAllowed,

  /// <summary>
  /// Filter by only_deleted.
  /// </summary>
  [JsonApiName("only_deleted")]
  OnlyDeleted,

  /// <summary>
  /// Filter by recently_viewed.
  /// </summary>
  [JsonApiName("recently_viewed")]
  RecentlyViewed,

  /// <summary>
  /// Filter by unassigned.
  /// </summary>
  [JsonApiName("unassigned")]
  Unassigned,

  /// <summary>
  /// Filter by with_deleted.
  /// </summary>
  [JsonApiName("with_deleted")]
  WithDeleted,

  /// <summary>
  /// Filter by with_recoverable.
  /// </summary>
  [JsonApiName("with_recoverable")]
  WithRecoverable,

  /// <summary>
  /// Filter by with_steps.
  /// </summary>
  [JsonApiName("with_steps")]
  WithSteps,

}

