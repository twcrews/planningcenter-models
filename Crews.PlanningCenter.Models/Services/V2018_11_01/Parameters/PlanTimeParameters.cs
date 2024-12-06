namespace Crews.PlanningCenter.Models.Services.V2018_11_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.PlanTime" />.
/// </summary>
public enum PlanTimeIncludable
{
  /// <summary>
  /// include associated split_team_rehearsal_assignments
  /// </summary>
  [JsonApiName("split_team_rehearsal_assignments")]
  SplitTeamRehearsalAssignments,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.PlanTime" />.
/// </summary>
public enum PlanTimeOrderable
{
  /// <summary>
  /// prefix with a hyphen (-starts_at) to reverse the order
  /// </summary>
  [JsonApiName("starts_at")]
  StartsAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.PlanTime" />.
/// </summary>
public enum PlanTimeQueryable
{
  /// <summary>
  /// Query on a specific time_type
  /// </summary>
  [JsonApiName("time_type")]
  TimeType,

}

