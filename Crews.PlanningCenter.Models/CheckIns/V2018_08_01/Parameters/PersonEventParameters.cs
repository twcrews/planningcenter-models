namespace Crews.PlanningCenter.Models.CheckIns.V2018_08_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.PersonEvent" />.
/// </summary>
public enum PersonEventIncludable
{
  /// <summary>
  /// include associated event
  /// </summary>
  Event,

  /// <summary>
  /// include associated first_check_in
  /// </summary>
  FirstCheckIn,

  /// <summary>
  /// include associated last_check_in
  /// </summary>
  LastCheckIn,

  /// <summary>
  /// include associated person
  /// </summary>
  Person,

}

