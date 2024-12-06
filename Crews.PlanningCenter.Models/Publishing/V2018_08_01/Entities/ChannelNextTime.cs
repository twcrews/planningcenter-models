using System.Text.Json;

namespace Crews.PlanningCenter.Models.Publishing.V2018_08_01.Entities;

/// <summary>
/// The next default time for a channel
/// </summary>
[JsonApiName("channel_next_time")]
public record ChannelNextTime
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

}
