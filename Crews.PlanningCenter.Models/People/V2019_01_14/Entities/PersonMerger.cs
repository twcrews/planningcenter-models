using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2019_01_14.Entities;

/// <summary>
/// A Person Merger is the history of profiles that were merged into other profiles.
/// </summary>
public record PersonMerger
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? PersonToKeepId { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? PersonToRemoveId { get; init; }

}