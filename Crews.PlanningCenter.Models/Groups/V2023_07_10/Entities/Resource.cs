using System.Text.Json;

namespace Crews.PlanningCenter.Models.Groups.V2023_07_10.Entities;

/// <summary>
/// A file or link resource that can be shared with a group.
/// </summary>
[JsonApiName("resource")]
public record Resource
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// The description of the resource written by the person who created it.
  /// </summary>
  [JsonApiName("description")]
  public string? Description { get; init; }

  /// <summary>
  /// The date and time the resource was last updated.
  /// </summary>
  [JsonApiName("last_updated")]
  public DateTime? LastUpdated { get; init; }

  /// <summary>
  /// The name/title of the resource.
  /// </summary>
  [JsonApiName("name")]
  public string? Name { get; init; }

  /// <summary>
  /// Either <c>FileResource</c> or <c>LinkResource</c>
  /// </summary>
  [JsonApiName("type")]
  public string? Type { get; init; }

  /// <summary>
  /// Possible values: <c>leaders</c> or <c>members</c>
  /// </summary>
  [JsonApiName("visibility")]
  public string? Visibility { get; init; }

}
