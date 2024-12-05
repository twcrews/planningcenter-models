namespace Crews.PlanningCenter.Models.People.V2022_07_14.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Workflow" />.
/// </summary>
public enum WorkflowIncludable
{
  /// <summary>
  /// include associated category
  /// </summary>
  Category,

  /// <summary>
  /// include associated shares
  /// </summary>
  Shares,

  /// <summary>
  /// include associated steps
  /// </summary>
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
  CampusId,

  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-deleted_at) to reverse the order
  /// </summary>
  DeletedAt,

  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
  Name,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  UpdatedAt,

  /// <summary>
  /// prefix with a hyphen (-workflow_category_id) to reverse the order
  /// </summary>
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
  CampusId,

  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  CreatedAt,

  /// <summary>
  /// Query on a specific deleted_at
  /// </summary>
  DeletedAt,

  /// <summary>
  /// Query on a specific id
  /// </summary>
  Id,

  /// <summary>
  /// Query on a specific name
  /// </summary>
  Name,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  UpdatedAt,

  /// <summary>
  /// Query on a specific workflow_category_id
  /// </summary>
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
  HasMyCards,

  /// <summary>
  /// Filter by manage_cards_allowed.
  /// </summary>
  ManageCardsAllowed,

  /// <summary>
  /// Filter by only_deleted.
  /// </summary>
  OnlyDeleted,

  /// <summary>
  /// Filter by recently_viewed.
  /// </summary>
  RecentlyViewed,

  /// <summary>
  /// Filter by unassigned.
  /// </summary>
  Unassigned,

  /// <summary>
  /// Filter by with_deleted.
  /// </summary>
  WithDeleted,

  /// <summary>
  /// Filter by with_recoverable.
  /// </summary>
  WithRecoverable,

  /// <summary>
  /// Filter by with_steps.
  /// </summary>
  WithSteps,

}

