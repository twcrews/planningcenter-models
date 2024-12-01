using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2020_07_22.Entities;

/// <summary>
/// Workflow Note is a note that has been made on a Workflow Card
/// </summary>
public record WorkflowCardNote
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Note { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? CreatedAt { get; init; }

}
