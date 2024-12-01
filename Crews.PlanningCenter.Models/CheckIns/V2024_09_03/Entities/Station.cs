using System.Text.Json;

namespace Crews.PlanningCenter.Models.CheckIns.V2024_09_03.Entities;

/// <summary>
/// A device where people can be checked in.
/// A device may also be connected to a printer
/// and print labels for itself or other stations.
/// 
/// </summary>
public record Station
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// Only available when requested with the `?fields` param
  /// </summary>
  public bool? Online { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public int? Mode { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Name { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public int? TimeoutSeconds { get; init; }

  /// <summary>
  /// Possible values: `scanner` or `keypad`
  /// </summary>
  public string? InputType { get; init; }

  /// <summary>
  /// Possible values: `all_input_types`, `only_keypad`, or `only_scanner`
  /// </summary>
  public string? InputTypeOptions { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// Only available when requested with the `?fields` param
  /// </summary>
  public DateTime? NextShowsAt { get; init; }

  /// <summary>
  /// Only available when requested with the `?fields` param
  /// </summary>
  public bool? OpenForCheckIn { get; init; }

  /// <summary>
  /// Only available when requested with the `?fields` param
  /// </summary>
  public DateTime? ClosesAt { get; init; }

  /// <summary>
  /// Only available when requested with the `?fields` param
  /// </summary>
  public int? CheckInCount { get; init; }

}
