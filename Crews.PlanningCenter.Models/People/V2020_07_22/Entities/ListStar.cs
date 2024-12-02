using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2020_07_22.Entities;

/// <summary>
/// A starred list for a person indicates it is special in some way
/// </summary>
public record ListStar
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? CreatedAt { get; init; }

}
