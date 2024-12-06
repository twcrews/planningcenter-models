using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2023_03_21.Entities;

/// <summary>
/// A starred list for a person indicates it is special in some way
/// </summary>
[JsonApiName("list_star")]
public record ListStar
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

}
