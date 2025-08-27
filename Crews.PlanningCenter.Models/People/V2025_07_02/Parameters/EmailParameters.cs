namespace Crews.PlanningCenter.Models.People.V2025_07_02.Parameters;

/// <summary>
/// Orderable attributes for <see cref="Entities.Email" />.
/// </summary>
public enum EmailOrderable
{
  /// <summary>
  /// prefix with a hyphen (-address) to reverse the order
  /// </summary>
  [JsonApiName("address")]
  Address,

  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-location) to reverse the order
  /// </summary>
  [JsonApiName("location")]
  Location,

  /// <summary>
  /// prefix with a hyphen (-primary) to reverse the order
  /// </summary>
  [JsonApiName("primary")]
  Primary,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Email" />.
/// </summary>
public enum EmailQueryable
{
  /// <summary>
  /// Query on a specific address
  /// </summary>
  [JsonApiName("address")]
  Address,

  /// <summary>
  /// Query on a specific blocked
  /// </summary>
  [JsonApiName("blocked")]
  Blocked,

  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// Query on a specific location
  /// </summary>
  [JsonApiName("location")]
  Location,

  /// <summary>
  /// Query on a specific primary
  /// </summary>
  [JsonApiName("primary")]
  Primary,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

}

