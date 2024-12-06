using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2022_01_28.Entities;

/// <summary>
/// A PeopleImport is a record of an ongoing or previous import from a CSV file.
/// </summary>
[JsonApiName("people_import")]
public record PeopleImport
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("attribs")]
  public string? Attribs { get; init; }

  /// <summary>
  /// Possible values: <c>matching</c>, <c>processing_preview</c>, <c>previewing</c>, <c>processing_import</c>, <c>complete</c>, <c>undone</c>, or <c>undoing</c>
  /// </summary>
  [JsonApiName("status")]
  public string? Status { get; init; }

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
  [JsonApiName("processed_at")]
  public DateTime? ProcessedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("undone_at")]
  public DateTime? UndoneAt { get; init; }

}
