namespace Crews.PlanningCenter.Models.People.V2018_08_01.Parameters;

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

