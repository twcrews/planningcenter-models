namespace Crews.PlanningCenter.Models.People.V2018_08_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.List" />.
/// </summary>
public enum ListIncludable
{
  /// <summary>
  /// include associated campus
  /// </summary>
  Campus,

  /// <summary>
  /// include associated category
  /// </summary>
  Category,

  /// <summary>
  /// include associated created_by
  /// </summary>
  CreatedBy,

  /// <summary>
  /// include associated mailchimp_sync_status
  /// </summary>
  MailchimpSyncStatus,

  /// <summary>
  /// include associated owner
  /// </summary>
  Owner,

  /// <summary>
  /// include associated people
  /// </summary>
  People,

  /// <summary>
  /// include associated rules
  /// </summary>
  Rules,

  /// <summary>
  /// include associated shares
  /// </summary>
  Shares,

  /// <summary>
  /// include associated updated_by
  /// </summary>
  UpdatedBy,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.List" />.
/// </summary>
public enum ListOrderable
{
  /// <summary>
  /// prefix with a hyphen (-batch_completed_at) to reverse the order
  /// </summary>
  BatchCompletedAt,

  /// <summary>
  /// prefix with a hyphen (-campus_id) to reverse the order
  /// </summary>
  CampusId,

  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-list_category_id) to reverse the order
  /// </summary>
  ListCategoryId,

  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
  Name,

  /// <summary>
  /// prefix with a hyphen (-name_or_description) to reverse the order
  /// </summary>
  NameOrDescription,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  UpdatedAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.List" />.
/// </summary>
public enum ListQueryable
{
  /// <summary>
  /// Query on a specific batch_completed_at
  /// </summary>
  BatchCompletedAt,

  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  CreatedAt,

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

}

/// <summary>
/// Filterable attributes for <see cref="Entities.List" />.
/// </summary>
public enum ListFilterable
{
  /// <summary>
  /// Filter by can_manage.
  /// </summary>
  CanManage,

  /// <summary>
  /// Filter by recently_viewed.
  /// </summary>
  RecentlyViewed,

  /// <summary>
  /// Filter by starred.
  /// </summary>
  Starred,

  /// <summary>
  /// Filter by unassigned.
  /// </summary>
  Unassigned,

}

