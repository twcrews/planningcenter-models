using System.Text.Json;

namespace Crews.PlanningCenter.Models.CheckIns.V2024_09_03.Entities;

/// <summary>
/// A CheckInTime combines an EventTime and a Location, and associates it with
/// the parent CheckIn.
/// </summary>
[JsonApiName("check_in_time")]
public record CheckInTime
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("kind")]
  public string? Kind { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("has_validated")]
  public bool? HasValidated { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("services_integrated")]
  public bool? ServicesIntegrated { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("alerts")]
  public IEnumerable<JsonElement>? Alerts { get; init; }

}
