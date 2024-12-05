namespace Crews.PlanningCenter.Models.People.V2018_08_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Form" />.
/// </summary>
public enum FormIncludable
{
  /// <summary>
  /// include associated campus
  /// </summary>
  Campus,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.Form" />.
/// </summary>
public enum FormOrderable
{
  /// <summary>
  /// prefix with a hyphen (-active) to reverse the order
  /// </summary>
  Active,

  /// <summary>
  /// prefix with a hyphen (-archived_at) to reverse the order
  /// </summary>
  ArchivedAt,

  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-deleted_at) to reverse the order
  /// </summary>
  DeletedAt,

  /// <summary>
  /// prefix with a hyphen (-description) to reverse the order
  /// </summary>
  Description,

  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
  Name,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
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
  Active,

  /// <summary>
  /// Query on a specific id
  /// </summary>
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
  Archived,

  /// <summary>
  /// Filter by closed.
  /// </summary>
  Closed,

  /// <summary>
  /// Filter by not_archived.
  /// </summary>
  NotArchived,

  /// <summary>
  /// Filter by open.
  /// </summary>
  Open,

  /// <summary>
  /// Filter by recently_viewed.
  /// </summary>
  RecentlyViewed,

  /// <summary>
  /// Filter by with_recoverable.
  /// </summary>
  WithRecoverable,

}

