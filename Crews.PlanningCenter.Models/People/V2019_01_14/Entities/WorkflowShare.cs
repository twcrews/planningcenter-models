using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2019_01_14.Entities;

/// <summary>
/// A workflow share defines who can access a workflow.
/// </summary>
[JsonApiName("workflow_share")]
public record WorkflowShare
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Possible values: <c>No Access</c>, <c>Viewer</c>, <c>Editor</c>, or <c>Manager</c>
  /// </summary>
  [JsonApiName("group")]
  public string? Group { get; init; }

  /// <summary>
  /// Possible values: <c>view</c>, <c>manage_cards</c>, or <c>manage</c>
  /// </summary>
  [JsonApiName("permission")]
  public string? Permission { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("person_id")]
  public string? PersonId { get; init; }

}
