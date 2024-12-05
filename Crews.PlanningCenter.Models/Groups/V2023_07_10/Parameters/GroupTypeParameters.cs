namespace Crews.PlanningCenter.Models.Groups.V2023_07_10.Parameters;

/// <summary>
/// Orderable attributes for <see cref="Entities.GroupType" />.
/// </summary>
public enum GroupTypeOrderable
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
/// Queryable attributes for <see cref="Entities.GroupType" />.
/// </summary>
public enum GroupTypeQueryable
{
  /// <summary>
  /// Query on a specific id
  /// </summary>
  Id,

}

/// <summary>
/// Filterable attributes for <see cref="Entities.GroupType" />.
/// </summary>
public enum GroupTypeFilterable
{
  /// <summary>
  /// Filter by church_center_visible.
  /// </summary>
  ChurchCenterVisible,

  /// <summary>
  /// Filter by not_church_center_visible.
  /// </summary>
  NotChurchCenterVisible,

}

