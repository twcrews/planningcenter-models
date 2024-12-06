using System.Text.Json;

namespace Crews.PlanningCenter.Models.Services.V2018_11_01.Entities;

/// <summary>
/// A position within a team.
/// </summary>
[JsonApiName("team_position")]
public record TeamPosition
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
  /// If the Team is assigned via tags, these are specific Tags that are specified.
  /// </summary>
  [JsonApiName("tags")]
  public IEnumerable<JsonElement>? Tags { get; init; }

  /// <summary>
  /// If the Team is assigned via tags, these are Tags where the option "None" is specified.
  /// </summary>
  [JsonApiName("negative_tag_groups")]
  public IEnumerable<JsonElement>? NegativeTagGroups { get; init; }

  /// <summary>
  /// If the Team is assigned via tags, these are Tags where the option "Any" is specified.
  /// </summary>
  [JsonApiName("tag_groups")]
  public IEnumerable<JsonElement>? TagGroups { get; init; }

}
