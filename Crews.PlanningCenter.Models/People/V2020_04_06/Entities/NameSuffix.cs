using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2020_04_06.Entities;

/// <summary>
/// A name suffix is one of Sr., Jr., etc.
/// </summary>
public record NameSuffix
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Value { get; init; }

}
