namespace Crews.PlanningCenter.Models.Publishing.V2024_03_25.Parameters;

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

