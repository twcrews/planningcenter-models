using System.Text.Json;

namespace Crews.PlanningCenter.Models.Publishing.V2024_03_25.Entities;

/// <summary>
/// A collection of sermons
/// </summary>
[JsonApiName("channel")]
public record Channel
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("art")]
  public JsonElement? Art { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("podcast_art")]
  public JsonElement? PodcastArt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("podcast_settings")]
  public JsonElement? PodcastSettings { get; init; }

  /// <summary>
  /// The activation time for an episode, expressed in minutes before its start
  /// </summary>
  [JsonApiName("activate_episode_minutes_before")]
  public int? ActivateEpisodeMinutesBefore { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("can_enable_chat")]
  public bool? CanEnableChat { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("church_center_url")]
  public string? ChurchCenterUrl { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("created_at")]
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("default_video_embed_code")]
  public string? DefaultVideoEmbedCode { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("description")]
  public string? Description { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("url")]
  public string? Url { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("default_video_duration")]
  public int? DefaultVideoDuration { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("default_video_url")]
  public string? DefaultVideoUrl { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("enable_audio")]
  public bool? EnableAudio { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("enable_on_demand_video")]
  public bool? EnableOnDemandVideo { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("enable_watch_live")]
  public bool? EnableWatchLive { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("general_chat_enabled")]
  public bool? GeneralChatEnabled { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("group_chat_enabled")]
  public bool? GroupChatEnabled { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("name")]
  public string? Name { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("podcast_feed_url")]
  public string? PodcastFeedUrl { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("position")]
  public int? Position { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("published")]
  public bool? Published { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("sermon_notes_enabled")]
  public bool? SermonNotesEnabled { get; init; }

  /// <summary>
  /// The id for the associated Services Service Type (https://developer.planning.center/docs/#/apps/services/2018-08-01/vertices/service_type)
  /// </summary>
  [JsonApiName("services_service_type_remote_identifier")]
  public string? ServicesServiceTypeRemoteIdentifier { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("updated_at")]
  public DateTime? UpdatedAt { get; init; }

}
