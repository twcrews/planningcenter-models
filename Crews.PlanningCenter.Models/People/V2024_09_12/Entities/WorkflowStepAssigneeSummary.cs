namespace Crews.PlanningCenter.Models.People.V2024_09_12.Entities;

/// <summary>
/// The ready and snoozed count for an assignee &amp; step
/// </summary>
public record WorkflowStepAssigneeSummary
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public int? ReadyCount { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public int? SnoozedCount { get; init; }

}
