using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2021_08_17.Entities;

/// <summary>
/// A workflow share defines who can access a workflow.
/// </summary>
public record WorkflowShare
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// Possible values: `No Access`, `Viewer`, `Editor`, or `Manager`
  /// </summary>
  public string? Group { get; init; }

  /// <summary>
  /// Possible values: `view`, `manage_cards`, or `manage`
  /// </summary>
  public string? Permission { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? PersonId { get; init; }

}
