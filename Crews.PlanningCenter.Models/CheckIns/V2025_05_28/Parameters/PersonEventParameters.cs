namespace Crews.PlanningCenter.Models.CheckIns.V2025_05_28.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.PersonEvent" />.
/// </summary>
public enum PersonEventIncludable
{
  /// <summary>
  /// include associated event
  /// </summary>
  [JsonApiName("event")]
  Event,

  /// <summary>
  /// include associated first_check_in
  /// </summary>
  [JsonApiName("first_check_in")]
  FirstCheckIn,

  /// <summary>
  /// include associated last_check_in
  /// </summary>
  [JsonApiName("last_check_in")]
  LastCheckIn,

  /// <summary>
  /// include associated person
  /// </summary>
  [JsonApiName("person")]
  Person,

}

