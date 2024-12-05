namespace Crews.PlanningCenter.Models.Services.V2018_11_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.PlanPerson" />.
/// </summary>
public enum PlanPersonIncludable
{
  /// <summary>
  /// include associated declined_plan_times
  /// </summary>
  DeclinedPlanTimes,

  /// <summary>
  /// include associated person
  /// </summary>
  Person,

  /// <summary>
  /// include associated plan
  /// </summary>
  Plan,

  /// <summary>
  /// include associated team
  /// </summary>
  Team,

}

