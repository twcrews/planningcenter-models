using System.Text.Json;

namespace Crews.PlanningCenter.Models.Services.V2018_08_01.Entities;

/// <summary>
/// A piece of media
/// </summary>
[JsonApiName("media")]
public record Media
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("created_at")]
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("updated_at")]
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("themes")]
  public string? Themes { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("title")]
  public string? Title { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("thumbnail_file_name")]
  public string? ThumbnailFileName { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("thumbnail_content_type")]
  public string? ThumbnailContentType { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("thumbnail_file_size")]
  public int? ThumbnailFileSize { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("thumbnail_updated_at")]
  public DateTime? ThumbnailUpdatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("preview_file_name")]
  public string? PreviewFileName { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("preview_content_type")]
  public string? PreviewContentType { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("preview_file_size")]
  public int? PreviewFileSize { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("preview_updated_at")]
  public DateTime? PreviewUpdatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("length")]
  public int? Length { get; init; }

  /// <summary>
  /// Possible Values:
  /// 
  /// - <c>audio</c>
  /// 
  /// - <c>background_audio</c>
  /// 
  /// - <c>background_image</c>
  /// 
  /// - <c>background_video</c>
  /// 
  /// - <c>countdown</c>
  /// 
  /// - <c>curriculum</c>
  /// 
  /// - <c>document</c>
  /// 
  /// - <c>drama</c>
  /// 
  /// - <c>image</c>
  /// 
  /// - <c>powerpoint</c>
  /// 
  /// - <c>song_video</c>
  /// 
  /// - <c>video</c>
  /// </summary>
  [JsonApiName("media_type")]
  public string? MediaType { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("media_type_name")]
  public string? MediaTypeName { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("thumbnail_url")]
  public string? ThumbnailUrl { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("creator_name")]
  public string? CreatorName { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("preview_url")]
  public string? PreviewUrl { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("image_url")]
  public string? ImageUrl { get; init; }

}
