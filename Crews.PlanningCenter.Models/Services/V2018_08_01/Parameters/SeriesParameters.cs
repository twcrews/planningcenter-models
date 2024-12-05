namespace Crews.PlanningCenter.Models.Services.V2018_08_01.Parameters;

/// <summary>
/// Orderable attributes for <see cref="Entities.Series" />.
/// </summary>
public enum SeriesOrderable
{
  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  CreatedAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Series" />.
/// </summary>
public enum SeriesQueryable
{
  /// <summary>
  /// Query on a specific title
  /// </summary>
  Title,

}

