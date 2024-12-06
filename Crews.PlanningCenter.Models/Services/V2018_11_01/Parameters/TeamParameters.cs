namespace Crews.PlanningCenter.Models.Services.V2018_11_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Team" />.
/// </summary>
public enum TeamIncludable
{
  /// <summary>
  /// include associated people
  /// </summary>
  [JsonApiName("people")]
  People,

  /// <summary>
  /// include associated person_team_position_assignments
  /// </summary>
  [JsonApiName("person_team_position_assignments")]
  PersonTeamPositionAssignments,

  /// <summary>
  /// include associated service_type
  /// </summary>
  [JsonApiName("service_type")]
  ServiceType,

  /// <summary>
  /// include associated team_leaders
  /// </summary>
  [JsonApiName("team_leaders")]
  TeamLeaders,

  /// <summary>
  /// include associated team_positions
  /// </summary>
  [JsonApiName("team_positions")]
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
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
  [JsonApiName("name")]
  Name,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  [JsonApiName("updated_at")]
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
  [JsonApiName("name")]
  Name,

}

