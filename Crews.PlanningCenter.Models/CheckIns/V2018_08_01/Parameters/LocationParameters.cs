namespace Crews.PlanningCenter.Models.CheckIns.V2018_08_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Location" />.
/// </summary>
public enum LocationIncludable
{
  /// <summary>
  /// include associated event
  /// </summary>
  Event,

  /// <summary>
  /// include associated locations
  /// </summary>
  Locations,

  /// <summary>
  /// include associated options
  /// </summary>
  Options,

  /// <summary>
  /// include associated parent
  /// </summary>
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
  Kind,

  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
  Name,

  /// <summary>
  /// prefix with a hyphen (-position) to reverse the order
  /// </summary>
  Position,

}

