using System.Text.Json;

namespace Crews.PlanningCenter.Models.Services.V2018_11_01.Entities;

/// <summary>
/// A Layout is used for formatting text for each item in Projector.
/// </summary>
public record Layout
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? ID { get; init; }

}
