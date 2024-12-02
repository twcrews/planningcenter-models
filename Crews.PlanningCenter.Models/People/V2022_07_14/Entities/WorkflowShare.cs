namespace Crews.PlanningCenter.Models.People.V2022_07_14.Entities;

/// <summary>
/// A workflow share defines who can access a workflow.
/// </summary>
public record WorkflowShare
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// Possible values: <c>No Access</c>, <c>Viewer</c>, <c>Editor</c>, or <c>Manager</c>
  /// </summary>
  public string? Group { get; init; }

  /// <summary>
  /// Possible values: <c>view</c>, <c>manage_cards</c>, or <c>manage</c>
  /// </summary>
  public string? Permission { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? PersonId { get; init; }

}
