using System.Text.Json;

namespace Crews.PlanningCenter.Models.Publishing.V2024_03_25.Entities;

/// <summary>
/// Planning Center does not provide a description for this resource.
/// </summary>
public record Episode
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public JsonElement? Art { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? ChurchCenterUrl { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Description { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? LibraryAudioUrl { get; init; }

  /// <summary>
  /// Possible values: <c>vimeo</c>, <c>youtube</c>, <c>livestream_com</c>, <c>resi</c>, <c>facebook</c>, or <c>boxcast</c>
  /// </summary>
  public string? LibraryStreamingService { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? LibraryVideoThumbnailUrl { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? LibraryVideoUrl { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public bool? NeedsLibraryAudioOrVideoUrl { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public bool? NeedsVideoUrl { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public IEnumerable<JsonElement>? PageActions { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? PublishedLiveAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? PublishedToLibraryAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public JsonElement? SermonAudio { get; init; }

  /// <summary>
  /// Possible values: <c>channel_default_livestream</c>, <c>livestream</c>, or <c>prerecorded</c>
  /// </summary>
  public string? StreamType { get; init; }

  /// <summary>
  /// Possible values: <c>vimeo</c>, <c>youtube</c>, <c>livestream_com</c>, <c>resi</c>, <c>facebook</c>, or <c>boxcast</c>
  /// </summary>
  public string? StreamingService { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Title { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? VideoThumbnailUrl { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? VideoUrl { get; init; }

  /// <summary>
  /// The id for the associated Services Plan
  /// (https://developer.planning.center/docs/#/apps/services/2018-08-01/vertices/plan)
  /// </summary>
  public string? ServicesPlanRemoteIdentifier { get; init; }

  /// <summary>
  /// The id for the associated Services Service Type
  /// (https://developer.planning.center/docs/#/apps/services/2018-08-01/vertices/service_type)
  /// </summary>
  public string? ServicesServiceTypeRemoteIdentifier { get; init; }

}
