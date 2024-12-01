using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2018_08_01.Entities;

/// <summary>
/// A form submission value.
/// </summary>
public record FormSubmissionValue
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? DisplayValue { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public IEnumerable<JsonElement>? Attachments { get; init; }

}
