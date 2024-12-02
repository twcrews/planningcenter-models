using System.Text.Json;

namespace Crews.PlanningCenter.Models.Publishing.V2024_03_25.Entities;

/// <summary>
/// Live schedule times for an Episode
/// </summary>
public record EpisodeTime
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? StartsAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? EndsAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? VideoUrl { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? VideoEmbedCode { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public double? CurrentTimestamp { get; init; }

  /// <summary>
  /// Possible values: <c>upcoming</c>, <c>active</c>, <c>over</c>
  /// </summary>
  public string? CurrentState { get; init; }

  /// <summary>
  /// Possible values: <c>vimeo</c>, <c>youtube</c>, <c>livestream_com</c>, <c>resi</c>, <c>facebook</c>, <c>boxcast</c>
  /// </summary>
  public string? StreamingService { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public IEnumerable<JsonElement>? Caveats { get; init; }

}
