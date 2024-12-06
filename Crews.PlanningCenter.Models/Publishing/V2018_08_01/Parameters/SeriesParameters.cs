namespace Crews.PlanningCenter.Models.Publishing.V2018_08_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Series" />.
/// </summary>
public enum SeriesIncludable
{
  /// <summary>
  /// include associated channel
  /// </summary>
  [JsonApiName("channel")]
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
  [JsonApiName("ended_at")]
  EndedAt,

  /// <summary>
  /// prefix with a hyphen (-episodes_count) to reverse the order
  /// </summary>
  [JsonApiName("episodes_count")]
  EpisodesCount,

  /// <summary>
  /// prefix with a hyphen (-started_at) to reverse the order
  /// </summary>
  [JsonApiName("started_at")]
  StartedAt,

  /// <summary>
  /// prefix with a hyphen (-title) to reverse the order
  /// </summary>
  [JsonApiName("title")]
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
  [JsonApiName("id")]
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
  [JsonApiName("not_published")]
  NotPublished,

  /// <summary>
  /// Filter by published.
  /// </summary>
  [JsonApiName("published")]
  Published,

}

