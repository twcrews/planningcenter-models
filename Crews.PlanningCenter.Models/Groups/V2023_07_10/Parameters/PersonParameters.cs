namespace Crews.PlanningCenter.Models.Groups.V2023_07_10.Parameters;

/// <summary>
/// Orderable attributes for <see cref="Entities.Person" />.
/// </summary>
public enum PersonOrderable
{
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

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Person" />.
/// </summary>
public enum PersonQueryable
{
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

}

