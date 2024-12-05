namespace Crews.PlanningCenter.Models.Services.V2018_11_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.PersonTeamPositionAssignment" />.
/// </summary>
public enum PersonTeamPositionAssignmentIncludable
{
  /// <summary>
  /// include associated person
  /// </summary>
  Person,

  /// <summary>
  /// include associated team_position
  /// </summary>
  TeamPosition,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.PersonTeamPositionAssignment" />.
/// </summary>
public enum PersonTeamPositionAssignmentOrderable
{
  /// <summary>
  /// prefix with a hyphen (-first_name) to reverse the order
  /// </summary>
  FirstName,

  /// <summary>
  /// prefix with a hyphen (-last_name) to reverse the order
  /// </summary>
  LastName,

}

