namespace Crews.PlanningCenter.Models.Publishing.V2024_03_25.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Channel" />.
/// </summary>
public enum ChannelIncludable
{
  /// <summary>
  /// include associated channel_default_episode_resources
  /// </summary>
  ChannelDefaultEpisodeResources,

  /// <summary>
  /// include associated channel_default_times
  /// </summary>
  ChannelDefaultTimes,

  /// <summary>
  /// include associated current_episode
  /// </summary>
  CurrentEpisode,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.Channel" />.
/// </summary>
public enum ChannelOrderable
{
  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
  Name,

  /// <summary>
  /// prefix with a hyphen (-position) to reverse the order
  /// </summary>
  Position,

}

