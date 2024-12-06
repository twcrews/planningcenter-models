namespace Crews.PlanningCenter.Models.Services.V2018_11_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Person" />.
/// </summary>
public enum PersonIncludable
{
  /// <summary>
  /// include associated emails
  /// </summary>
  [JsonApiName("emails")]
  Emails,

  /// <summary>
  /// include associated tags
  /// </summary>
  [JsonApiName("tags")]
  Tags,

  /// <summary>
  /// include associated team_leaders
  /// </summary>
  [JsonApiName("team_leaders")]
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
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-first_name) to reverse the order
  /// </summary>
  [JsonApiName("first_name")]
  FirstName,

  /// <summary>
  /// prefix with a hyphen (-last_name) to reverse the order
  /// </summary>
  [JsonApiName("last_name")]
  LastName,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  [JsonApiName("updated_at")]
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
  [JsonApiName("assigned_to_rehearsal_team")]
  AssignedToRehearsalTeam,

  /// <summary>
  /// Query on a specific legacy_id
  /// </summary>
  [JsonApiName("legacy_id")]
  LegacyId,

}

