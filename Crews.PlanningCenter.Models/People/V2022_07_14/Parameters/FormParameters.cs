namespace Crews.PlanningCenter.Models.People.V2022_07_14.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Form" />.
/// </summary>
public enum FormIncludable
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

}

/// <summary>
/// Orderable attributes for <see cref="Entities.Form" />.
/// </summary>
public enum FormOrderable
{
  /// <summary>
  /// prefix with a hyphen (-active) to reverse the order
  /// </summary>
  [JsonApiName("active")]
  Active,

  /// <summary>
  /// prefix with a hyphen (-archived_at) to reverse the order
  /// </summary>
  [JsonApiName("archived_at")]
  ArchivedAt,

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
  /// prefix with a hyphen (-description) to reverse the order
  /// </summary>
  [JsonApiName("description")]
  Description,

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

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Form" />.
/// </summary>
public enum FormQueryable
{
  /// <summary>
  /// Query on a specific active
  /// </summary>
  [JsonApiName("active")]
  Active,

  /// <summary>
  /// Query on a specific id
  /// </summary>
  [JsonApiName("id")]
  Id,

}

/// <summary>
/// Filterable attributes for <see cref="Entities.Form" />.
/// </summary>
public enum FormFilterable
{
  /// <summary>
  /// Filter by archived.
  /// </summary>
  [JsonApiName("archived")]
  Archived,

  /// <summary>
  /// Filter by closed.
  /// </summary>
  [JsonApiName("closed")]
  Closed,

  /// <summary>
  /// Filter by not_archived.
  /// </summary>
  [JsonApiName("not_archived")]
  NotArchived,

  /// <summary>
  /// Filter by open.
  /// </summary>
  [JsonApiName("open")]
  Open,

  /// <summary>
  /// Filter by recently_viewed.
  /// </summary>
  [JsonApiName("recently_viewed")]
  RecentlyViewed,

  /// <summary>
  /// Filter by with_recoverable.
  /// </summary>
  [JsonApiName("with_recoverable")]
  WithRecoverable,

}

