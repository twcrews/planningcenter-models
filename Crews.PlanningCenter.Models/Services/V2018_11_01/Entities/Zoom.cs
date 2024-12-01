using System.Text.Json;

namespace Crews.PlanningCenter.Models.Services.V2018_11_01.Entities;

/// <summary>
/// Describes a zoom level for an attachment
/// </summary>
public record Zoom
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// The aspect ratio of the device this zoom is for. It is rounded to the nearest 3 decimal places.
  /// </summary>
  public double? AspectRatio { get; init; }

  /// <summary>
  /// The percentage of the zoom. Must be a value between 1.0 and 5.0
  /// </summary>
  public double? ZoomLevel { get; init; }

  /// <summary>
  /// The percentage of the document's width the zoomed document should be offset by horizontally.
  /// </summary>
  public double? XOffset { get; init; }

  /// <summary>
  /// The percentage of the document's height the zoomed document should be offset by vertically.
  /// </summary>
  public double? YOffset { get; init; }

}
