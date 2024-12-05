namespace Crews.PlanningCenter.Models.People.V2023_02_15.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Campus" />.
/// </summary>
public enum CampusIncludable
{
  /// <summary>
  /// include associated lists
  /// </summary>
  Lists,

  /// <summary>
  /// include associated service_times
  /// </summary>
  ServiceTimes,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.Campus" />.
/// </summary>
public enum CampusOrderable
{
  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  CreatedAt,

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
/// Queryable attributes for <see cref="Entities.Campus" />.
/// </summary>
public enum CampusQueryable
{
  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  CreatedAt,

  /// <summary>
  /// Query on a specific id
  /// </summary>
  Id,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  UpdatedAt,

}

