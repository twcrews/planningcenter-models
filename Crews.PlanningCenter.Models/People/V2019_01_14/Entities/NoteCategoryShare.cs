using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2019_01_14.Entities;

/// <summary>
/// A note category share defines who can view notes in a category.
/// </summary>
[JsonApiName("note_category_share")]
public record NoteCategoryShare
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Possible values: <c>No Access</c>, <c>Viewer</c>, <c>Editor</c>, or <c>Manager</c>
  /// </summary>
  [JsonApiName("group")]
  public string? Group { get; init; }

  /// <summary>
  /// Possible values: <c>view</c> or <c>view_create</c>
  /// </summary>
  [JsonApiName("permission")]
  public string? Permission { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("person_id")]
  public string? PersonId { get; init; }

}
