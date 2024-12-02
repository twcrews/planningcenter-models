namespace Crews.PlanningCenter.Models.Services.V2018_11_01.Entities;

/// <summary>
/// For Rehearsal/Other Times, maps a Split Team to selected Time Preference Options. For example, used to assign 8am Ushers to 7:30am call time, and 11am Ushers to 10:30am call time.
/// </summary>
public record SplitTeamRehearsalAssignment
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// Controls if the related rehearsal/other time is assigned when a person is scheduled to a split team service time that does not match a Time Preference Option
  /// </summary>
  public bool? ScheduleSpecialServiceTimes { get; init; }

}
