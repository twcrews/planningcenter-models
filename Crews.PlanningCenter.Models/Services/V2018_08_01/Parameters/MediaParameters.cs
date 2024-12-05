namespace Crews.PlanningCenter.Models.Services.V2018_08_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Media" />.
/// </summary>
public enum MediaIncludable
{
  /// <summary>
  /// include associated attachments
  /// </summary>
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
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-title) to reverse the order
  /// </summary>
  Title,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
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
  CreatorName,

  /// <summary>
  /// Query on a specific id
  /// </summary>
  Id,

  /// <summary>
  /// Query on a specific themes
  /// </summary>
  Themes,

  /// <summary>
  /// Query on a specific title
  /// </summary>
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
  Archived,

  /// <summary>
  /// Filter by audio.
  /// </summary>
  Audio,

  /// <summary>
  /// Filter by background_audio.
  /// </summary>
  BackgroundAudio,

  /// <summary>
  /// Filter by background_image.
  /// </summary>
  BackgroundImage,

  /// <summary>
  /// Filter by background_video.
  /// </summary>
  BackgroundVideo,

  /// <summary>
  /// Filter by countdown.
  /// </summary>
  Countdown,

  /// <summary>
  /// Filter by document.
  /// </summary>
  Document,

  /// <summary>
  /// Filter by drama.
  /// </summary>
  Drama,

  /// <summary>
  /// Filter by image.
  /// </summary>
  Image,

  /// <summary>
  /// Filter by not_archived.
  /// </summary>
  NotArchived,

  /// <summary>
  /// Filter by powerpoint.
  /// </summary>
  Powerpoint,

  /// <summary>
  /// Filter by song_video.
  /// </summary>
  SongVideo,

  /// <summary>
  /// Filter by video.
  /// </summary>
  Video,

}

