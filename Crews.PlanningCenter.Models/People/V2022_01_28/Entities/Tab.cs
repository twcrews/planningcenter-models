using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2022_01_28.Entities;

/// <summary>
/// A tab is a custom tab and groups like field definitions.
/// </summary>
[JsonApiName("tab")]
public record Tab
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("name")]
  public string? Name { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("sequence")]
  public int? Sequence { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("slug")]
  public string? Slug { get; init; }

}
