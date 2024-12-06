namespace Crews.PlanningCenter.Models.Publishing.V2018_08_01.Parameters;

/// <summary>
/// Orderable attributes for <see cref="Entities.EpisodeTime" />.
/// </summary>
public enum EpisodeTimeOrderable
{
  /// <summary>
  /// prefix with a hyphen (-starts_at) to reverse the order
  /// </summary>
  [JsonApiName("starts_at")]
  StartsAt,

}

