using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2025_07_17.Entities;

/// <summary>
/// A subscription for note categories
/// </summary>
[JsonApiName("note_category_subscription")]
public record NoteCategorySubscription
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
  [JsonApiName("updated_at")]
  public DateTime? UpdatedAt { get; init; }

}
