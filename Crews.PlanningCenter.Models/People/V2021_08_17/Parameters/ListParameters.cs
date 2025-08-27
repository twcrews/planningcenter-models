namespace Crews.PlanningCenter.Models.People.V2021_08_17.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.List" />.
/// </summary>
public enum ListIncludable
{
  /// <summary>
  /// include associated campus
  /// </summary>
  [JsonApiName("campus")]
  Campus,

  /// <summary>
  /// include associated category
  /// </summary>
  [JsonApiName("category")]
  Category,

  /// <summary>
  /// include associated created_by
  /// </summary>
  [JsonApiName("created_by")]
  CreatedBy,

  /// <summary>
  /// include associated mailchimp_sync_status
  /// </summary>
  [JsonApiName("mailchimp_sync_status")]
  MailchimpSyncStatus,

  /// <summary>
  /// include associated people
  /// </summary>
  [JsonApiName("people")]
  People,

  /// <summary>
  /// include associated rules
  /// </summary>
  [JsonApiName("rules")]
  Rules,

  /// <summary>
  /// include associated shares
  /// </summary>
  [JsonApiName("shares")]
  Shares,

  /// <summary>
  /// include associated updated_by
  /// </summary>
  [JsonApiName("updated_by")]
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
  [JsonApiName("batch_completed_at")]
  BatchCompletedAt,

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
  /// prefix with a hyphen (-list_categories.name) to reverse the order
  /// </summary>
  [JsonApiName("list_categories.name")]
  ListCategoriesName,

  /// <summary>
  /// prefix with a hyphen (-list_category_id) to reverse the order
  /// </summary>
  [JsonApiName("list_category_id")]
  ListCategoryId,

  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
  [JsonApiName("name")]
  Name,

  /// <summary>
  /// prefix with a hyphen (-name_or_description) to reverse the order
  /// </summary>
  [JsonApiName("name_or_description")]
  NameOrDescription,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  [JsonApiName("updated_at")]
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
  [JsonApiName("batch_completed_at")]
  BatchCompletedAt,

  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

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

}

/// <summary>
/// Filterable attributes for <see cref="Entities.List" />.
/// </summary>
public enum ListFilterable
{
  /// <summary>
  /// Filter by can_manage.
  /// </summary>
  [JsonApiName("can_manage")]
  CanManage,

  /// <summary>
  /// Filter by recently_viewed.
  /// </summary>
  [JsonApiName("recently_viewed")]
  RecentlyViewed,

  /// <summary>
  /// Filter by starred.
  /// </summary>
  [JsonApiName("starred")]
  Starred,

  /// <summary>
  /// Filter by unassigned.
  /// </summary>
  [JsonApiName("unassigned")]
  Unassigned,

}

