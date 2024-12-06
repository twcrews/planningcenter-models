using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2021_08_17.Entities;

/// <summary>
/// A Person Merger is the history of profiles that were merged into other profiles.
/// </summary>
[JsonApiName("person_merger")]
public record PersonMerger
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("created_at")]
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("person_to_keep_id")]
  public string? PersonToKeepId { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("person_to_remove_id")]
  public string? PersonToRemoveId { get; init; }

}
