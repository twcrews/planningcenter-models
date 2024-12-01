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
  public string? Id { get; init; }

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
  /// Possible values: `upcoming`, `active`, `over`
  /// 
  /// </summary>
  public string? CurrentState { get; init; }

  /// <summary>
  /// Possible values: `vimeo`, `youtube`, `livestream_com`, `resi`, `facebook`, `boxcast`
  /// 
  /// </summary>
  public string? StreamingService { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public IEnumerable<JsonElement>? Caveats { get; init; }

}
