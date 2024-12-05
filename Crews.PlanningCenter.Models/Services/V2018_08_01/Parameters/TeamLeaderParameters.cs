namespace Crews.PlanningCenter.Models.Services.V2018_08_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.TeamLeader" />.
/// </summary>
public enum TeamLeaderIncludable
{
  /// <summary>
  /// include associated people
  /// </summary>
  People,

  /// <summary>
  /// include associated team
  /// </summary>
  Team,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.TeamLeader" />.
/// </summary>
public enum TeamLeaderOrderable
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

