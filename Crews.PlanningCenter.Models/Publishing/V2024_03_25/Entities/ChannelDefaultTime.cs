using System.Text.Json;

namespace Crews.PlanningCenter.Models.Publishing.V2024_03_25.Entities;

/// <summary>
/// The default times for a channel
/// </summary>
[JsonApiName("channel_default_time")]
public record ChannelDefaultTime
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// The day of the week. 0 is Sunday, 1 is Monday, etc.
  /// </summary>
  [JsonApiName("day_of_week")]
  public int? DayOfWeek { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("hour")]
  public int? Hour { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("minute")]
  public int? Minute { get; init; }

  /// <summary>
  /// Possible values: <c>weekly</c>
  /// </summary>
  [JsonApiName("frequency")]
  public string? Frequency { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("position")]
  public int? Position { get; init; }

}
