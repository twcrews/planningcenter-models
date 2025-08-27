using System.Text.Json;

namespace Crews.PlanningCenter.Models.Publishing.V2018_08_01.Entities;

/// <summary>
/// Planning Center does not provide a description for this resource.
/// </summary>
[JsonApiName("episode")]
public record Episode
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
  [JsonApiName("description")]
  public string? Description { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("library_audio_url")]
  public string? LibraryAudioUrl { get; init; }

  /// <summary>
  /// Possible values: <c>vimeo</c>, <c>youtube</c>, <c>livestream_com</c>, <c>resi</c>, <c>facebook</c>, or <c>boxcast</c>
  /// </summary>
  [JsonApiName("library_streaming_service")]
  public string? LibraryStreamingService { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("library_video_embed_code")]
  public string? LibraryVideoEmbedCode { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("library_video_thumbnail_url")]
  public string? LibraryVideoThumbnailUrl { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("library_video_url")]
  public string? LibraryVideoUrl { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("needs_library_audio_or_video_url")]
  public bool? NeedsLibraryAudioOrVideoUrl { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("needs_notes_template")]
  public bool? NeedsNotesTemplate { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("needs_video_url")]
  public bool? NeedsVideoUrl { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("page_actions")]
  public IEnumerable<JsonElement>? PageActions { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("published_live_at")]
  public DateTime? PublishedLiveAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("published_to_library_at")]
  public DateTime? PublishedToLibraryAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("sermon_audio")]
  public JsonElement? SermonAudio { get; init; }

  /// <summary>
  /// Possible values: <c>channel_default_livestream</c>, <c>livestream</c>, or <c>prerecorded</c>
  /// </summary>
  [JsonApiName("stream_type")]
  public string? StreamType { get; init; }

  /// <summary>
  /// Possible values: <c>vimeo</c>, <c>youtube</c>, <c>livestream_com</c>, <c>resi</c>, <c>facebook</c>, or <c>boxcast</c>
  /// </summary>
  [JsonApiName("streaming_service")]
  public string? StreamingService { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("title")]
  public string? Title { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("updated_at")]
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("video_thumbnail_url")]
  public string? VideoThumbnailUrl { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("video_embed_code")]
  public string? VideoEmbedCode { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("video_url")]
  public string? VideoUrl { get; init; }

  /// <summary>
  /// The id for the associated Services Plan
  /// (https://developer.planning.center/docs/#/apps/services/2018-08-01/vertices/plan)
  /// </summary>
  [JsonApiName("services_plan_remote_identifier")]
  public string? ServicesPlanRemoteIdentifier { get; init; }

  /// <summary>
  /// The id for the associated Services Service Type
  /// (https://developer.planning.center/docs/#/apps/services/2018-08-01/vertices/service_type)
  /// </summary>
  [JsonApiName("services_service_type_remote_identifier")]
  public string? ServicesServiceTypeRemoteIdentifier { get; init; }

}
