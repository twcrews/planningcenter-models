using System.Text.Json;

namespace Crews.PlanningCenter.Models.CheckIns.V2019_07_17.Entities;

/// <summary>
/// A device where people can be checked in.
/// A device may also be connected to a printer
/// and print labels for itself or other stations.
/// </summary>
[JsonApiName("station")]
public record Station
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("mode")]
  public int? Mode { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("name")]
  public string? Name { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("timeout_seconds")]
  public int? TimeoutSeconds { get; init; }

  /// <summary>
  /// Possible values: <c>scanner</c> or <c>keypad</c>
  /// </summary>
  [JsonApiName("input_type")]
  public string? InputType { get; init; }

  /// <summary>
  /// Possible values: <c>all_input_types</c>, <c>only_keypad</c>, or <c>only_scanner</c>
  /// </summary>
  [JsonApiName("input_type_options")]
  public string? InputTypeOptions { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("created_at")]
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("updated_at")]
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// Only available when requested with the <c>?fields</c> param
  /// </summary>
  [JsonApiName("next_shows_at")]
  public DateTime? NextShowsAt { get; init; }

  /// <summary>
  /// Only available when requested with the <c>?fields</c> param
  /// </summary>
  [JsonApiName("open_for_check_in")]
  public bool? OpenForCheckIn { get; init; }

  /// <summary>
  /// Only available when requested with the <c>?fields</c> param
  /// </summary>
  [JsonApiName("closes_at")]
  public DateTime? ClosesAt { get; init; }

  /// <summary>
  /// Only available when requested with the <c>?fields</c> param
  /// </summary>
  [JsonApiName("check_in_count")]
  public int? CheckInCount { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("online")]
  public bool? Online { get; init; }

}
