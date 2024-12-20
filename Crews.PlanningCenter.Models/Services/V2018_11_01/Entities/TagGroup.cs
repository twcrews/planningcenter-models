using System.Text.Json;

namespace Crews.PlanningCenter.Models.Services.V2018_11_01.Entities;

/// <summary>
/// A tag group contains tags
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
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("name")]
  public string? Name { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("required")]
  public bool? Required { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("allow_multiple_selections")]
  public bool? AllowMultipleSelections { get; init; }

  /// <summary>
  /// Scopes a tag group to <c>person</c>, <c>song</c>, <c>arrangement</c>, <c>media</c>
  /// </summary>
  [JsonApiName("tags_for")]
  public string? TagsFor { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("service_type_folder_name")]
  public string? ServiceTypeFolderName { get; init; }

}
