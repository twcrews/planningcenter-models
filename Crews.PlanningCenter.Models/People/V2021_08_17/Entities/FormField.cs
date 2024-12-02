namespace Crews.PlanningCenter.Models.People.V2021_08_17.Entities;

/// <summary>
/// A field in a custom form.
/// </summary>
public record FormField
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Label { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Description { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public bool? Required { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Settings { get; init; }

  /// <summary>
  /// Possible values: <c>string</c>, <c>text</c>, <c>checkboxes</c>, <c>dropdown</c>, <c>date</c>, <c>phone_number</c>, <c>address</c>, <c>birthday</c>, <c>gender</c>, <c>custom_field</c>, <c>note</c>, <c>workflow</c>, <c>heading</c>, <c>number</c>, <c>boolean</c>, <c>file</c>, <c>medical</c>, <c>workflow_checkbox</c>, <c>workflow_checkboxes</c>, <c>workflow_dropdown</c>, <c>marital_status</c>, <c>anniversary</c>, <c>grade</c>, <c>primary_campus</c>, <c>school</c>, or <c>household</c>
  /// </summary>
  public string? FieldType { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public int? Sequence { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

}
