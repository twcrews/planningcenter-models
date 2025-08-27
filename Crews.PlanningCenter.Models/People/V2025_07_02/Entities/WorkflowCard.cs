using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2025_07_02.Entities;

/// <summary>
/// A Card
/// </summary>
[JsonApiName("workflow_card")]
public record WorkflowCard
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("snooze_until")]
  public DateTime? SnoozeUntil { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("overdue")]
  public bool? Overdue { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("stage")]
  public string? Stage { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("calculated_due_at_in_days_ago")]
  public int? CalculatedDueAtInDaysAgo { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("sticky_assignment")]
  public bool? StickyAssignment { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("created_at")]
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("updated_at")]
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("completed_at")]
  public DateTime? CompletedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("flagged_for_notification_at")]
  public DateTime? FlaggedForNotificationAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("removed_at")]
  public DateTime? RemovedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("moved_to_step_at")]
  public DateTime? MovedToStepAt { get; init; }

}
