using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2019_01_14.Entities;

/// <summary>
/// A list share indicates who has access to edit a list.
/// </summary>
[JsonApiName("list_share")]
public record ListShare
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Possible values: <c>view</c> or <c>manage</c>
  /// </summary>
  [JsonApiName("permission")]
  public string? Permission { get; init; }

  /// <summary>
  /// Possible values: <c>No Access</c>, <c>Viewer</c>, <c>Editor</c>, or <c>Manager</c>
  /// </summary>
  [JsonApiName("group")]
  public string? Group { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("created_at")]
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("name")]
  public string? Name { get; init; }

}
