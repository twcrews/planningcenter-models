using System.Text.Json;

namespace Crews.PlanningCenter.Models.Publishing.V2018_08_01.Entities;

/// <summary>
/// Live schedule times for an Episode
/// </summary>
[JsonApiName("episode_time")]
public record EpisodeTime
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("starts_at")]
  public DateTime? StartsAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("ends_at")]
  public DateTime? EndsAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("video_url")]
  public string? VideoUrl { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("video_embed_code")]
  public string? VideoEmbedCode { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("current_timestamp")]
  public double? CurrentTimestamp { get; init; }

  /// <summary>
  /// Possible values: <c>upcoming</c>, <c>active</c>, <c>over</c>
  /// </summary>
  [JsonApiName("current_state")]
  public string? CurrentState { get; init; }

  /// <summary>
  /// Possible values: <c>vimeo</c>, <c>youtube</c>, <c>livestream_com</c>, <c>resi</c>, <c>facebook</c>, <c>boxcast</c>
  /// </summary>
  [JsonApiName("streaming_service")]
  public string? StreamingService { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("caveats")]
  public IEnumerable<JsonElement>? Caveats { get; init; }

}
