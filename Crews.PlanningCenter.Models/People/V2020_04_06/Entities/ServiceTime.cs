using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2020_04_06.Entities;

/// <summary>
/// A ServiceTime Resource
/// </summary>
public record ServiceTime
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public int? StartTime { get; init; }

  /// <summary>
  /// Possible values: <c>sunday</c>, <c>monday</c>, <c>tuesday</c>, <c>wednesday</c>, <c>thursday</c>, <c>friday</c>, or <c>saturday</c>
  /// </summary>
  public string? Day { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Description { get; init; }

}
