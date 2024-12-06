namespace Crews.PlanningCenter.Models.Services.V2018_11_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Media" />.
/// </summary>
public enum MediaIncludable
{
  /// <summary>
  /// include associated attachments
  /// </summary>
  [JsonApiName("attachments")]
  Attachments,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.Media" />.
/// </summary>
public enum MediaOrderable
{
  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-title) to reverse the order
  /// </summary>
  [JsonApiName("title")]
  Title,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Media" />.
/// </summary>
public enum MediaQueryable
{
  /// <summary>
  /// Query on a specific creator_name
  /// </summary>
  [JsonApiName("creator_name")]
  CreatorName,

  /// <summary>
  /// Query on a specific id
  /// </summary>
  [JsonApiName("id")]
  Id,

  /// <summary>
  /// Query on a specific themes
  /// </summary>
  [JsonApiName("themes")]
  Themes,

  /// <summary>
  /// Query on a specific title
  /// </summary>
  [JsonApiName("title")]
  Title,

}

/// <summary>
/// Filterable attributes for <see cref="Entities.Media" />.
/// </summary>
public enum MediaFilterable
{
  /// <summary>
  /// Filter by archived.
  /// </summary>
  [JsonApiName("archived")]
  Archived,

  /// <summary>
  /// Filter by audio.
  /// </summary>
  [JsonApiName("audio")]
  Audio,

  /// <summary>
  /// Filter by background_audio.
  /// </summary>
  [JsonApiName("background_audio")]
  BackgroundAudio,

  /// <summary>
  /// Filter by background_image.
  /// </summary>
  [JsonApiName("background_image")]
  BackgroundImage,

  /// <summary>
  /// Filter by background_video.
  /// </summary>
  [JsonApiName("background_video")]
  BackgroundVideo,

  /// <summary>
  /// Filter by countdown.
  /// </summary>
  [JsonApiName("countdown")]
  Countdown,

  /// <summary>
  /// Filter by document.
  /// </summary>
  [JsonApiName("document")]
  Document,

  /// <summary>
  /// Filter by drama.
  /// </summary>
  [JsonApiName("drama")]
  Drama,

  /// <summary>
  /// Filter by image.
  /// </summary>
  [JsonApiName("image")]
  Image,

  /// <summary>
  /// Filter by not_archived.
  /// </summary>
  [JsonApiName("not_archived")]
  NotArchived,

  /// <summary>
  /// Filter by powerpoint.
  /// </summary>
  [JsonApiName("powerpoint")]
  Powerpoint,

  /// <summary>
  /// Filter by song_video.
  /// </summary>
  [JsonApiName("song_video")]
  SongVideo,

  /// <summary>
  /// Filter by video.
  /// </summary>
  [JsonApiName("video")]
  Video,

}

