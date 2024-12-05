namespace Crews.PlanningCenter.Models.Services.V2018_11_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Team" />.
/// </summary>
public enum TeamIncludable
{
  /// <summary>
  /// include associated people
  /// </summary>
  People,

  /// <summary>
  /// include associated person_team_position_assignments
  /// </summary>
  PersonTeamPositionAssignments,

  /// <summary>
  /// include associated service_type
  /// </summary>
  ServiceType,

  /// <summary>
  /// include associated team_leaders
  /// </summary>
  TeamLeaders,

  /// <summary>
  /// include associated team_positions
  /// </summary>
  TeamPositions,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.Team" />.
/// </summary>
public enum TeamOrderable
{
  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
  Name,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  UpdatedAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Team" />.
/// </summary>
public enum TeamQueryable
{
  /// <summary>
  /// Query on a specific name
  /// </summary>
  Name,

}

