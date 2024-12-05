namespace Crews.PlanningCenter.Models.Publishing.V2018_08_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Episode" />.
/// </summary>
public enum EpisodeIncludable
{
  /// <summary>
  /// include associated channel
  /// </summary>
  Channel,

  /// <summary>
  /// include associated episode_resources
  /// </summary>
  EpisodeResources,

  /// <summary>
  /// include associated episode_times
  /// </summary>
  EpisodeTimes,

  /// <summary>
  /// include associated series
  /// </summary>
  Series,

  /// <summary>
  /// include associated speakerships
  /// </summary>
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
  PublishedLiveAt,

  /// <summary>
  /// prefix with a hyphen (-published_to_library_at) to reverse the order
  /// </summary>
  PublishedToLibraryAt,

  /// <summary>
  /// prefix with a hyphen (-stream_type) to reverse the order
  /// </summary>
  StreamType,

  /// <summary>
  /// prefix with a hyphen (-title) to reverse the order
  /// </summary>
  Title,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Episode" />.
/// </summary>
public enum EpisodeQueryable
{
  /// <summary>
  /// Query on a specific services_plan_remote_identifier
  /// </summary>
  ServicesPlanRemoteIdentifier,

  /// <summary>
  /// Query on a specific services_service_type_remote_identifier
  /// </summary>
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
  ConnectedToServices,

  /// <summary>
  /// Filter by not_connected_to_services.
  /// </summary>
  NotConnectedToServices,

  /// <summary>
  /// Filter by not_published_live.
  /// </summary>
  NotPublishedLive,

  /// <summary>
  /// Filter by published_live.
  /// </summary>
  PublishedLive,

  /// <summary>
  /// Filter by published_on_church_center.
  /// </summary>
  PublishedOnChurchCenter,

}

