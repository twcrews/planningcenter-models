using System.Text.Json;

namespace Crews.PlanningCenter.Models.Services.V2018_08_01.Entities;

/// <summary>
/// A specific plan note within a single plan.
/// </summary>
public record PlanNote
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? ID { get; init; }

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
  public string? CategoryName { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Content { get; init; }

}
