namespace Crews.PlanningCenter.Models.People.V2020_04_06.Entities;

/// <summary>
/// A field option represents an individual option for a custom field of type "select" or "checkboxes".
/// </summary>
public record FieldOption
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Value { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public int? Sequence { get; init; }

}
