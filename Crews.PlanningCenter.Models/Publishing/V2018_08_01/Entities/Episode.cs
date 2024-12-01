using System.Text.Json;

namespace Crews.PlanningCenter.Models.Publishing.V2018_08_01.Entities;

/// <summary>
/// Planning Center does not provide a description for this resource.
/// </summary>
public record Episode
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Id { get; init; }

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
  /// Possible values: `vimeo`, `youtube`, `livestream_com`, `resi`, `facebook`, or `boxcast`
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
  /// Possible values: `channel_default_livestream`, `livestream`, or `prerecorded`
  /// </summary>
  public string? StreamType { get; init; }

  /// <summary>
  /// Possible values: `vimeo`, `youtube`, `livestream_com`, `resi`, `facebook`, or `boxcast`
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
  /// 
  /// </summary>
  public string? ServicesPlanRemoteIdentifier { get; init; }

  /// <summary>
  /// The id for the associated Services Service Type
  /// (https://developer.planning.center/docs/#/apps/services/2018-08-01/vertices/service_type)
  /// 
  /// </summary>
  public string? ServicesServiceTypeRemoteIdentifier { get; init; }

}