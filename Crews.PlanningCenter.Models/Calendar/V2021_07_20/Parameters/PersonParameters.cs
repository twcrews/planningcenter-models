namespace Crews.PlanningCenter.Models.Calendar.V2021_07_20.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Person" />.
/// </summary>
public enum PersonIncludable
{
  /// <summary>
  /// include associated organization
  /// </summary>
  [JsonApiName("organization")]
  Organization,

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
  /// prefix with a hyphen (-resolves_conflicts) to reverse the order
  /// </summary>
  [JsonApiName("resolves_conflicts")]
  ResolvesConflicts,

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
  /// Query on a specific created_at
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// Query on a specific first_name
  /// </summary>
  [JsonApiName("first_name")]
  FirstName,

  /// <summary>
  /// Query on a specific last_name
  /// </summary>
  [JsonApiName("last_name")]
  LastName,

  /// <summary>
  /// Query on a specific middle_name
  /// </summary>
  [JsonApiName("middle_name")]
  MiddleName,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

}

/// <summary>
/// Filterable attributes for <see cref="Entities.Person" />.
/// </summary>
public enum PersonFilterable
{
  /// <summary>
  /// Filter by active.
  /// </summary>
  [JsonApiName("active")]
  Active,

  /// <summary>
  /// Filter by event_owners.
  /// </summary>
  [JsonApiName("event_owners")]
  EventOwners,

}

