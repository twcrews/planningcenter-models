namespace Crews.PlanningCenter.Models.People.V2020_07_22.Parameters;

/// <summary>
/// Orderable attributes for <see cref="Entities.WorkflowCardNote" />.
/// </summary>
public enum WorkflowCardNoteOrderable
{
  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

}

