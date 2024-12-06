using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2022_07_14.Entities;

/// <summary>
/// The ready and snoozed count for an assignee &amp; step
/// </summary>
[JsonApiName("workflow_step_assignee_summary")]
public record WorkflowStepAssigneeSummary
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("ready_count")]
  public int? ReadyCount { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("snoozed_count")]
  public int? SnoozedCount { get; init; }

}
