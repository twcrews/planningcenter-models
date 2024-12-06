namespace Crews.PlanningCenter.Models.People.V2021_08_17.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.WorkflowStepAssigneeSummary" />.
/// </summary>
public enum WorkflowStepAssigneeSummaryIncludable
{
  /// <summary>
  /// include associated person
  /// </summary>
  [JsonApiName("person")]
  Person,

}

