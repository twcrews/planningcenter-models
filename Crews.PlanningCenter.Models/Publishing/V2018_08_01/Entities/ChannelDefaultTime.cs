using System.Text.Json;

namespace Crews.PlanningCenter.Models.Publishing.V2018_08_01.Entities;

/// <summary>
/// The default times for a channel
/// </summary>
public record ChannelDefaultTime
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// The day of the week. 0 is Sunday, 1 is Monday, etc.
  /// 
  /// </summary>
  public int? DayOfWeek { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public int? Hour { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public int? Minute { get; init; }

  /// <summary>
  /// Possible values: `weekly`
  /// 
  /// </summary>
  public string? Frequency { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public int? Position { get; init; }

}