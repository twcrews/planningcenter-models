using System.Text.Json;

namespace Crews.PlanningCenter.Models.Groups.V2018_08_01.Entities;

/// <summary>
/// A way to group related tags.
/// For example you could have a "Life Stage" tag group
/// with tags like "Child", "Teen", "Adult", etc.
/// </summary>
[JsonApiName("tag_group")]
public record TagGroup
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Whether or not this tag group is visible to the public on Church Center
  /// </summary>
  [JsonApiName("display_publicly")]
  public bool? DisplayPublicly { get; init; }

  /// <summary>
  /// Whether or not a group can belong to many tags within this tag group
  /// </summary>
  [JsonApiName("multiple_options_enabled")]
  public bool? MultipleOptionsEnabled { get; init; }

  /// <summary>
  /// The name of the tag group
  /// </summary>
  [JsonApiName("name")]
  public string? Name { get; init; }

  /// <summary>
  /// The position of the tag group in relation to other tag groups
  /// </summary>
  [JsonApiName("position")]
  public int? Position { get; init; }

}
