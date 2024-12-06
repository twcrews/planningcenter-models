using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2024_09_12.Entities;

/// <summary>
/// A Step
/// </summary>
[JsonApiName("workflow_step")]
public record WorkflowStep
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("sequence")]
  public int? Sequence { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("name")]
  public string? Name { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("description")]
  public string? Description { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("expected_response_time_in_days")]
  public int? ExpectedResponseTimeInDays { get; init; }

  /// <summary>
  /// Must be a positive number
  /// </summary>
  [JsonApiName("auto_snooze_value")]
  public int? AutoSnoozeValue { get; init; }

  /// <summary>
  /// Valid values are <c>day</c>, <c>week</c>, or <c>month</c>
  /// 
  /// Possible values: <c>day</c>, <c>week</c>, or <c>month</c>
  /// </summary>
  [JsonApiName("auto_snooze_interval")]
  public string? AutoSnoozeInterval { get; init; }

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
  [JsonApiName("auto_snooze_days")]
  public int? AutoSnoozeDays { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("my_ready_card_count")]
  public int? MyReadyCardCount { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("total_ready_card_count")]
  public int? TotalReadyCardCount { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("default_assignee_id")]
  public string? DefaultAssigneeId { get; init; }

}
