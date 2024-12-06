using System.Text.Json;

namespace Crews.PlanningCenter.Models.Groups.V2018_08_01.Entities;

/// <summary>
/// A group type is a category of groups.
/// For example, a church might have group types for "Small Groups" and "Classes".
/// </summary>
[JsonApiName("group_type")]
public record GroupType
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// <c>true</c> if the group type contains any published groups. Otherwise <c>false</c>.
  /// </summary>
  [JsonApiName("church_center_visible")]
  public bool? ChurchCenterVisible { get; init; }

  /// <summary>
  /// <c>true</c> if the map view is visible on the public groups list page. Otherwise <c>false</c>.
  /// </summary>
  [JsonApiName("church_center_map_visible")]
  public bool? ChurchCenterMapVisible { get; init; }

  /// <summary>
  /// Hex color value. Color themes are a visual tool for administrators on the admin side of Groups.
  /// Ex: "#4fd2e3"
  /// </summary>
  [JsonApiName("color")]
  public string? Color { get; init; }

  /// <summary>
  /// A JSON object of default settings for groups of this type.
  /// </summary>
  [JsonApiName("default_group_settings")]
  public string? DefaultGroupSettings { get; init; }

  /// <summary>
  /// A description of the group type
  /// </summary>
  [JsonApiName("description")]
  public string? Description { get; init; }

  /// <summary>
  /// The name of the group type
  /// </summary>
  [JsonApiName("name")]
  public string? Name { get; init; }

  /// <summary>
  /// The position of the group type in relation to other group types.
  /// </summary>
  [JsonApiName("position")]
  public int? Position { get; init; }

}
