namespace Crews.PlanningCenter.Models.Publishing.V2018_08_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Channel" />.
/// </summary>
public enum ChannelIncludable
{
  /// <summary>
  /// include associated channel_default_episode_resources
  /// </summary>
  [JsonApiName("channel_default_episode_resources")]
  ChannelDefaultEpisodeResources,

  /// <summary>
  /// include associated channel_default_times
  /// </summary>
  [JsonApiName("channel_default_times")]
  ChannelDefaultTimes,

  /// <summary>
  /// include associated current_episode
  /// </summary>
  [JsonApiName("current_episode")]
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
  [JsonApiName("name")]
  Name,

  /// <summary>
  /// prefix with a hyphen (-position) to reverse the order
  /// </summary>
  [JsonApiName("position")]
  Position,

}

