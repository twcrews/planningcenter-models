using System.Text.Json;

namespace Crews.PlanningCenter.Models.CheckIns.V2024_09_03.Entities;

/// <summary>
/// When one or more people check in, they're grouped in a <c>CheckInGroup</c>.
/// These check-ins all have the same "checked-in by" person.
/// </summary>
[JsonApiName("check_in_group")]
public record CheckInGroup
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("name_labels_count")]
  public int? NameLabelsCount { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("security_labels_count")]
  public int? SecurityLabelsCount { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("check_ins_count")]
  public int? CheckInsCount { get; init; }

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
  /// Possible values:
  /// - <c>ready</c>: This group isn't printed or canceled yet
  /// - <c>printed</c>: This group was successfully printed at a station
  /// - <c>canceled</c>: This group was canceled at a station
  /// - <c>skipped</c>: This group had no labels to print, so it was never printed.
  /// </summary>
  [JsonApiName("print_status")]
  public string? PrintStatus { get; init; }

}
