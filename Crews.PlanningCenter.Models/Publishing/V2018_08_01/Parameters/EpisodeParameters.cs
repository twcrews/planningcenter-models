namespace Crews.PlanningCenter.Models.Publishing.V2018_08_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Episode" />.
/// </summary>
public enum EpisodeIncludable
{
  /// <summary>
  /// include associated channel
  /// </summary>
  [JsonApiName("channel")]
  Channel,

  /// <summary>
  /// include associated episode_resources
  /// </summary>
  [JsonApiName("episode_resources")]
  EpisodeResources,

  /// <summary>
  /// include associated episode_times
  /// </summary>
  [JsonApiName("episode_times")]
  EpisodeTimes,

  /// <summary>
  /// include associated series
  /// </summary>
  [JsonApiName("series")]
  Series,

  /// <summary>
  /// include associated speakerships
  /// </summary>
  [JsonApiName("speakerships")]
  Speakerships,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.Episode" />.
/// </summary>
public enum EpisodeOrderable
{
  /// <summary>
  /// prefix with a hyphen (-published_live_at) to reverse the order
  /// </summary>
  [JsonApiName("published_live_at")]
  PublishedLiveAt,

  /// <summary>
  /// prefix with a hyphen (-published_to_library_at) to reverse the order
  /// </summary>
  [JsonApiName("published_to_library_at")]
  PublishedToLibraryAt,

  /// <summary>
  /// prefix with a hyphen (-stream_type) to reverse the order
  /// </summary>
  [JsonApiName("stream_type")]
  StreamType,

  /// <summary>
  /// prefix with a hyphen (-title) to reverse the order
  /// </summary>
  [JsonApiName("title")]
  Title,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Episode" />.
/// </summary>
public enum EpisodeQueryable
{
  /// <summary>
  /// Query on a related series
  /// </summary>
  [JsonApiName("series_id")]
  SeriesId,

  /// <summary>
  /// Query on a specific services_plan_remote_identifier
  /// </summary>
  [JsonApiName("services_plan_remote_identifier")]
  ServicesPlanRemoteIdentifier,

  /// <summary>
  /// Query on a specific services_service_type_remote_identifier
  /// </summary>
  [JsonApiName("services_service_type_remote_identifier")]
  ServicesServiceTypeRemoteIdentifier,

}

/// <summary>
/// Filterable attributes for <see cref="Entities.Episode" />.
/// </summary>
public enum EpisodeFilterable
{
  /// <summary>
  /// Filter by connected_to_services.
  /// </summary>
  [JsonApiName("connected_to_services")]
  ConnectedToServices,

  /// <summary>
  /// Filter by not_connected_to_services.
  /// </summary>
  [JsonApiName("not_connected_to_services")]
  NotConnectedToServices,

  /// <summary>
  /// Filter by not_published_live.
  /// </summary>
  [JsonApiName("not_published_live")]
  NotPublishedLive,

  /// <summary>
  /// Filter by published_live.
  /// </summary>
  [JsonApiName("published_live")]
  PublishedLive,

  /// <summary>
  /// Filter by published_on_church_center.
  /// </summary>
  [JsonApiName("published_on_church_center")]
  PublishedOnChurchCenter,

}

