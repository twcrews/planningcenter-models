namespace Crews.PlanningCenter.Models.CheckIns.V2023_04_05.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Location" />.
/// </summary>
public enum LocationIncludable
{
  /// <summary>
  /// include associated event
  /// </summary>
  [JsonApiName("event")]
  Event,

  /// <summary>
  /// include associated locations
  /// </summary>
  [JsonApiName("locations")]
  Locations,

  /// <summary>
  /// include associated options
  /// </summary>
  [JsonApiName("options")]
  Options,

  /// <summary>
  /// include associated parent
  /// </summary>
  [JsonApiName("parent")]
  Parent,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.Location" />.
/// </summary>
public enum LocationOrderable
{
  /// <summary>
  /// prefix with a hyphen (-kind) to reverse the order
  /// </summary>
  [JsonApiName("kind")]
  Kind,

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

