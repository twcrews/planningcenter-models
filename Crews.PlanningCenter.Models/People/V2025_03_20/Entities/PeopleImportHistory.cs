using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2025_03_20.Entities;

/// <summary>
/// A PeopleImportHistory is a record of change that occurred when the parent PeopleImport was completed.
/// </summary>
[JsonApiName("people_import_history")]
public record PeopleImportHistory
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
  [JsonApiName("created_at")]
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("updated_at")]
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("conflicting_changes")]
  public JsonElement? ConflictingChanges { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("kind")]
  public string? Kind { get; init; }

}
