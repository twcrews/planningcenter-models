using System.Text.Json;

namespace Crews.PlanningCenter.Models.Groups.V2023_07_10.Entities;

/// <summary>
/// A way to group related tags.
/// For example you could have a "Life Stage" tag group
/// with tags like "Child", "Teen", "Adult", etc.
/// 
/// </summary>
public record TagGroup
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// Whether or not this tag group is visible to the public on Church Center
  /// 
  /// </summary>
  public bool? DisplayPublicly { get; init; }

  /// <summary>
  /// Whether or not a group can belong to many tags within this tag group
  /// 
  /// </summary>
  public bool? MultipleOptionsEnabled { get; init; }

  /// <summary>
  /// The name of the tag group
  /// 
  /// </summary>
  public string? Name { get; init; }

  /// <summary>
  /// The position of the tag group in relation to other tag groups
  /// 
  /// </summary>
  public int? Position { get; init; }

}
