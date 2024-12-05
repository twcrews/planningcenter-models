namespace Crews.PlanningCenter.Models.Calendar.V2020_04_08.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Tag" />.
/// </summary>
public enum TagIncludable
{
  /// <summary>
  /// include associated tag_group
  /// </summary>
  TagGroup,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.Tag" />.
/// </summary>
public enum TagOrderable
{
  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
  Name,

  /// <summary>
  /// prefix with a hyphen (-position) to reverse the order
  /// </summary>
  Position,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Tag" />.
/// </summary>
public enum TagQueryable
{
  /// <summary>
  /// Query on a specific church_center_category
  /// </summary>
  ChurchCenterCategory,

  /// <summary>
  /// Query on a specific color
  /// </summary>
  Color,

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
  /// Query on a specific position
  /// </summary>
  Position,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  UpdatedAt,

}

/// <summary>
/// Filterable attributes for <see cref="Entities.Tag" />.
/// </summary>
public enum TagFilterable
{
  /// <summary>
  /// Filter by individual.
  /// </summary>
  Individual,

}

