namespace Crews.PlanningCenter.Models.CheckIns.V2025_05_28.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Station" />.
/// </summary>
public enum StationIncludable
{
  /// <summary>
  /// include associated event
  /// </summary>
  [JsonApiName("event")]
  Event,

  /// <summary>
  /// include associated location
  /// </summary>
  [JsonApiName("location")]
  Location,

  /// <summary>
  /// include associated print_station
  /// </summary>
  [JsonApiName("print_station")]
  PrintStation,

  /// <summary>
  /// include associated theme
  /// </summary>
  [JsonApiName("theme")]
  Theme,

}

