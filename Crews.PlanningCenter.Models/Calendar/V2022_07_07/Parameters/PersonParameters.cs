namespace Crews.PlanningCenter.Models.Calendar.V2022_07_07.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Person" />.
/// </summary>
public enum PersonIncludable
{
  /// <summary>
  /// include associated organization
  /// </summary>
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
  /// prefix with a hyphen (-resolves_conflicts) to reverse the order
  /// </summary>
  ResolvesConflicts,

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
  /// Query on a specific created_at
  /// </summary>
  CreatedAt,

  /// <summary>
  /// Query on a specific first_name
  /// </summary>
  FirstName,

  /// <summary>
  /// Query on a specific last_name
  /// </summary>
  LastName,

  /// <summary>
  /// Query on a specific middle_name
  /// </summary>
  MiddleName,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
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
  Active,

  /// <summary>
  /// Filter by event_owners.
  /// </summary>
  EventOwners,

}

