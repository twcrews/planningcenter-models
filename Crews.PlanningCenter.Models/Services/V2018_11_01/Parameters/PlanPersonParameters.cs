namespace Crews.PlanningCenter.Models.Services.V2018_11_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.PlanPerson" />.
/// </summary>
public enum PlanPersonIncludable
{
  /// <summary>
  /// include associated declined_plan_times
  /// </summary>
  [JsonApiName("declined_plan_times")]
  DeclinedPlanTimes,

  /// <summary>
  /// include associated person
  /// </summary>
  [JsonApiName("person")]
  Person,

  /// <summary>
  /// include associated plan
  /// </summary>
  [JsonApiName("plan")]
  Plan,

  /// <summary>
  /// include associated team
  /// </summary>
  [JsonApiName("team")]
  Team,

}

