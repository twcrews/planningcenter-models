using System.Text.Json;

namespace Crews.PlanningCenter.Models.Services.V2018_08_01.Entities;

/// <summary>
/// Describes a zoom level for an attachment
/// </summary>
[JsonApiName("zoom")]
public record Zoom
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// The aspect ratio of the device this zoom is for. It is rounded to the nearest 3 decimal places.
  /// </summary>
  [JsonApiName("aspect_ratio")]
  public double? AspectRatio { get; init; }

  /// <summary>
  /// The percentage of the zoom. Must be a value between 1.0 and 5.0
  /// </summary>
  [JsonApiName("zoom_level")]
  public double? ZoomLevel { get; init; }

  /// <summary>
  /// The percentage of the document's width the zoomed document should be offset by horizontally.
  /// </summary>
  [JsonApiName("x_offset")]
  public double? XOffset { get; init; }

  /// <summary>
  /// The percentage of the document's height the zoomed document should be offset by vertically.
  /// </summary>
  [JsonApiName("y_offset")]
  public double? YOffset { get; init; }

}
