using System.Text.Json;

namespace Crews.PlanningCenter.Models.Services.V2018_11_01.Entities;

/// <summary>
/// Manage options for a public plan
/// </summary>
[JsonApiName("public_view")]
public record PublicView
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("series_artwork")]
  public bool? SeriesArtwork { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("series_and_plan_titles")]
  public bool? SeriesAndPlanTitles { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("item_descriptions")]
  public bool? ItemDescriptions { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("item_lengths")]
  public bool? ItemLengths { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("service_times")]
  public bool? ServiceTimes { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("song_items")]
  public bool? SongItems { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("media_items")]
  public bool? MediaItems { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("regular_items")]
  public bool? RegularItems { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("headers")]
  public bool? Headers { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("itunes")]
  public bool? Itunes { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("amazon")]
  public bool? Amazon { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("spotify")]
  public bool? Spotify { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("youtube")]
  public bool? Youtube { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("vimeo")]
  public bool? Vimeo { get; init; }

}
