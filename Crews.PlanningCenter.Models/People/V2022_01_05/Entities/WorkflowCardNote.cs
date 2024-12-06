using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2022_01_05.Entities;

/// <summary>
/// Workflow Note is a note that has been made on a Workflow Card
/// </summary>
[JsonApiName("workflow_card_note")]
public record WorkflowCardNote
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("note")]
  public string? Note { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("created_at")]
  public DateTime? CreatedAt { get; init; }

}
