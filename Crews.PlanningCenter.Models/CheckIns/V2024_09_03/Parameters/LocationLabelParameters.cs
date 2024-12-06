namespace Crews.PlanningCenter.Models.CheckIns.V2024_09_03.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.LocationLabel" />.
/// </summary>
public enum LocationLabelIncludable
{
  /// <summary>
  /// include associated label
  /// </summary>
  [JsonApiName("label")]
  Label,

  /// <summary>
  /// include associated location
  /// </summary>
  [JsonApiName("location")]
  Location,

}

