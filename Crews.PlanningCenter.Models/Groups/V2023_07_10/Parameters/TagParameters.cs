namespace Crews.PlanningCenter.Models.Groups.V2023_07_10.Parameters;

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
  /// Query on a specific id
  /// </summary>
  Id,

  /// <summary>
  /// Query on a specific name
  /// </summary>
  Name,

}

