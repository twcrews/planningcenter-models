namespace Crews.PlanningCenter.Models.Groups.V2023_07_10.Entities;

/// <summary>
/// A physical event location
/// </summary>
public record Location
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// This preference controls how the location is displayed to non-members for public groups and events.
  /// 
  /// Possible values: <c>hidden</c>, <c>approximate</c>, or <c>exact</c>
  /// </summary>
  public string? DisplayPreference { get; init; }

  /// <summary>
  /// Ex: "1313 Disneyland Dr
  /// Anaheim, CA 92802" (may be approximate or <c>null</c>)
  /// Approximate address would be "Anaheim, CA 92802".
  /// We obscure Canadian zip codes.
  /// </summary>
  public string? FullFormattedAddress { get; init; }

  /// <summary>
  /// Ex: <c>33.815396</c> (may be approximate or <c>null</c>)
  /// </summary>
  public double? Latitude { get; init; }

  /// <summary>
  /// Ex: <c>-117.926399</c> (may be approximate or <c>null</c>)
  /// </summary>
  public double? Longitude { get; init; }

  /// <summary>
  /// Ex: "Disneyland"
  /// </summary>
  public string? Name { get; init; }

  /// <summary>
  /// The number of miles in a location's approximate address.
  /// Will be <c>0</c> if the strategy is exact, and will be <c>null</c> if the strategy is hidden.
  /// </summary>
  public string? Radius { get; init; }

  /// <summary>
  /// The display preference strategy used for the current request, based on user permissions.
  /// Either <c>hidden</c>, <c>approximate</c>, or <c>exact</c>.
  /// </summary>
  public string? Strategy { get; init; }

}
