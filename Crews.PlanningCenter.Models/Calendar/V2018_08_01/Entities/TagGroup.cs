using System.Text.Json;

namespace Crews.PlanningCenter.Models.Calendar.V2018_08_01.Entities;

/// <summary>
/// A grouping of tags for organizational purposes.
/// </summary>
[JsonApiName("tag_group")]
public record TagGroup
{
  /// <summary>
  /// Unique identifier for the tag group
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// UTC time at which the tag group was created
  /// </summary>
  [JsonApiName("created_at")]
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// The name of the tag group
  /// </summary>
  [JsonApiName("name")]
  public string? Name { get; init; }

  /// <summary>
  /// UTC time at which the tag group was updated
  /// </summary>
  [JsonApiName("updated_at")]
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// - <c>true</c> indicates tag from this tag group must be applied when creating an event
  /// </summary>
  [JsonApiName("required")]
  public bool? Required { get; init; }

}
