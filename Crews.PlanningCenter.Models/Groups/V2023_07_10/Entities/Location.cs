using System.Text.Json;

namespace Crews.PlanningCenter.Models.Groups.V2023_07_10.Entities;

/// <summary>
/// A physical event location
/// 
/// </summary>
public record Location
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// This preference controls how the location is displayed to non-members for public groups and events.
  /// 
  /// 
  /// Possible values: `hidden`, `approximate`, or `exact`
  /// </summary>
  public string? DisplayPreference { get; init; }

  /// <summary>
  /// Ex: "1313 Disneyland Dr
  /// Anaheim, CA 92802" (may be approximate or `null`)
  /// Approximate address would be "Anaheim, CA 92802".
  /// We obscure Canadian zip codes.
  /// 
  /// </summary>
  public string? FullFormattedAddress { get; init; }

  /// <summary>
  /// Ex: `33.815396` (may be approximate or `null`)
  /// 
  /// </summary>
  public double? Latitude { get; init; }

  /// <summary>
  /// Ex: `-117.926399` (may be approximate or `null`)
  /// 
  /// </summary>
  public double? Longitude { get; init; }

  /// <summary>
  /// Ex: "Disneyland"
  /// 
  /// </summary>
  public string? Name { get; init; }

  /// <summary>
  /// The number of miles in a location's approximate address.
  /// Will be `0` if the strategy is exact, and will be `null` if the strategy is hidden.
  /// 
  /// </summary>
  public string? Radius { get; init; }

  /// <summary>
  /// The display preference strategy used for the current request, based on user permissions.
  /// Either `hidden`, `approximate`, or `exact`.
  /// 
  /// </summary>
  public string? Strategy { get; init; }

}
