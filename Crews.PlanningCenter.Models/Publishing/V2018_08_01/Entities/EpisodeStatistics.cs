using System.Text.Json;

namespace Crews.PlanningCenter.Models.Publishing.V2018_08_01.Entities;

/// <summary>
/// Viewership statistics for an episode
/// </summary>
[JsonApiName("episode_statistics")]
public record EpisodeStatistics
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// <c>watch_count</c> per EpisodeTime
  /// </summary>
  [JsonApiName("times")]
  public IEnumerable<JsonElement>? Times { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("library_watch_count")]
  public bool? LibraryWatchCount { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("live_watch_count")]
  public bool? LiveWatchCount { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("published_to_library_at")]
  public DateTime? PublishedToLibraryAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("published_live_at")]
  public DateTime? PublishedLiveAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("title")]
  public string? Title { get; init; }

}
