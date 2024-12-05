namespace Crews.PlanningCenter.Models.Services.V2018_11_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Person" />.
/// </summary>
public enum PersonIncludable
{
  /// <summary>
  /// include associated emails
  /// </summary>
  Emails,

  /// <summary>
  /// include associated tags
  /// </summary>
  Tags,

  /// <summary>
  /// include associated team_leaders
  /// </summary>
  TeamLeaders,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.Person" />.
/// </summary>
public enum PersonOrderable
{
  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-first_name) to reverse the order
  /// </summary>
  FirstName,

  /// <summary>
  /// prefix with a hyphen (-last_name) to reverse the order
  /// </summary>
  LastName,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  UpdatedAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Person" />.
/// </summary>
public enum PersonQueryable
{
  /// <summary>
  /// Query on a specific assigned_to_rehearsal_team
  /// </summary>
  AssignedToRehearsalTeam,

  /// <summary>
  /// Query on a specific legacy_id
  /// </summary>
  LegacyId,

}

