namespace Crews.PlanningCenter.Models.People.V2023_02_15.Entities;

/// <summary>
/// A PeopleImport is a record of an ongoing or previous import from a CSV file.
/// </summary>
public record PeopleImport
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Attribs { get; init; }

  /// <summary>
  /// Possible values: <c>matching</c>, <c>processing_preview</c>, <c>previewing</c>, <c>processing_import</c>, <c>complete</c>, <c>undone</c>, or <c>undoing</c>
  /// </summary>
  public string? Status { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? ProcessedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? UndoneAt { get; init; }

}
