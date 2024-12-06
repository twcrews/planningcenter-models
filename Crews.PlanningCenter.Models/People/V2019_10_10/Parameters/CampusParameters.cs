namespace Crews.PlanningCenter.Models.People.V2019_10_10.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Campus" />.
/// </summary>
public enum CampusIncludable
{
  /// <summary>
  /// include associated lists
  /// </summary>
  [JsonApiName("lists")]
  Lists,

  /// <summary>
  /// include associated service_times
  /// </summary>
  [JsonApiName("service_times")]
  ServiceTimes,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.Campus" />.
/// </summary>
public enum CampusOrderable
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
/// Queryable attributes for <see cref="Entities.Campus" />.
/// </summary>
public enum CampusQueryable
{
  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// Query on a specific id
  /// </summary>
  [JsonApiName("id")]
  Id,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

}

