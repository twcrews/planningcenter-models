namespace Crews.PlanningCenter.Models.Services.V2018_08_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.NeededPosition" />.
/// </summary>
public enum NeededPositionIncludable
{
  /// <summary>
  /// include associated team
  /// </summary>
  [JsonApiName("team")]
  Team,

  /// <summary>
  /// include associated time
  /// </summary>
  [JsonApiName("time")]
  Time,

}

