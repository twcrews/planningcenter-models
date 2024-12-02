namespace Crews.PlanningCenter.Models.People.V2019_01_14.Entities;

/// <summary>
/// A Step
/// </summary>
public record WorkflowStep
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public int? Sequence { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Name { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Description { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public int? ExpectedResponseTimeInDays { get; init; }

  /// <summary>
  /// Must be a positive number
  /// </summary>
  public int? AutoSnoozeValue { get; init; }

  /// <summary>
  /// Valid values are <c>day</c>, <c>week</c>, or <c>month</c>
  /// 
  /// Possible values: <c>day</c>, <c>week</c>, or <c>month</c>
  /// </summary>
  public string? AutoSnoozeInterval { get; init; }

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
  public int? AutoSnoozeDays { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public int? MyReadyCardCount { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public int? TotalReadyCardCount { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? DefaultAssigneeId { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public int? TotalSnoozedCardCount { get; init; }

}
