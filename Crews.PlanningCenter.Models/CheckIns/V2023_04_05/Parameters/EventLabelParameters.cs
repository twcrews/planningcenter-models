namespace Crews.PlanningCenter.Models.CheckIns.V2023_04_05.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.EventLabel" />.
/// </summary>
public enum EventLabelIncludable
{
  /// <summary>
  /// include associated event
  /// </summary>
  [JsonApiName("event")]
  Event,

  /// <summary>
  /// include associated label
  /// </summary>
  [JsonApiName("label")]
  Label,

}

