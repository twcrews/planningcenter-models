namespace Crews.PlanningCenter.Models.Groups.V2023_07_10.Parameters;

/// <summary>
/// Orderable attributes for <see cref="Entities.TagGroup" />.
/// </summary>
public enum TagGroupOrderable
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
/// Queryable attributes for <see cref="Entities.TagGroup" />.
/// </summary>
public enum TagGroupQueryable
{
  /// <summary>
  /// Query on a specific name
  /// </summary>
  Name,

}

/// <summary>
/// Filterable attributes for <see cref="Entities.TagGroup" />.
/// </summary>
public enum TagGroupFilterable
{
  /// <summary>
  /// Filter by public.
  /// </summary>
  Public,

}

