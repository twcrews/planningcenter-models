using System.Text.Json;

namespace Crews.PlanningCenter.Models.Groups.V2023_07_10.Entities;

/// <summary>
/// Tags are used to filter groups.
/// They can be organized into tag_groups.
/// </summary>
[JsonApiName("tag")]
public record Tag
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// The name of the tag
  /// </summary>
  [JsonApiName("name")]
  public string? Name { get; init; }

  /// <summary>
  /// The position of the tag in relation to other tags
  /// </summary>
  [JsonApiName("position")]
  public int? Position { get; init; }

}
