namespace Crews.PlanningCenter.Models.Publishing.V2018_08_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Series" />.
/// </summary>
public enum SeriesIncludable
{
  /// <summary>
  /// include associated channel
  /// </summary>
  Channel,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.Series" />.
/// </summary>
public enum SeriesOrderable
{
  /// <summary>
  /// prefix with a hyphen (-ended_at) to reverse the order
  /// </summary>
  EndedAt,

  /// <summary>
  /// prefix with a hyphen (-episodes_count) to reverse the order
  /// </summary>
  EpisodesCount,

  /// <summary>
  /// prefix with a hyphen (-started_at) to reverse the order
  /// </summary>
  StartedAt,

  /// <summary>
  /// prefix with a hyphen (-title) to reverse the order
  /// </summary>
  Title,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Series" />.
/// </summary>
public enum SeriesQueryable
{
  /// <summary>
  /// Query on a specific id
  /// </summary>
  Id,

}

/// <summary>
/// Filterable attributes for <see cref="Entities.Series" />.
/// </summary>
public enum SeriesFilterable
{
  /// <summary>
  /// Filter by not_published.
  /// </summary>
  NotPublished,

  /// <summary>
  /// Filter by published.
  /// </summary>
  Published,

}

