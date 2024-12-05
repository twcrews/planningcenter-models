namespace Crews.PlanningCenter.Models.Calendar.V2021_07_20.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.TagGroup" />.
/// </summary>
public enum TagGroupIncludable
{
  /// <summary>
  /// include associated events
  /// </summary>
  Events,

  /// <summary>
  /// include associated tags
  /// </summary>
  Tags,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.TagGroup" />.
/// </summary>
public enum TagGroupOrderable
{
  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
  Name,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.TagGroup" />.
/// </summary>
public enum TagGroupQueryable
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
  /// Query on a specific updated_at
  /// </summary>
  UpdatedAt,

}

/// <summary>
/// Filterable attributes for <see cref="Entities.TagGroup" />.
/// </summary>
public enum TagGroupFilterable
{
  /// <summary>
  /// Filter by required.
  /// </summary>
  Required,

}

