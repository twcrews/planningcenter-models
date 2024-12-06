namespace Crews.PlanningCenter.Models.People.V2023_03_21.Parameters;

/// <summary>
/// Orderable attributes for <see cref="Entities.PhoneNumber" />.
/// </summary>
public enum PhoneNumberOrderable
{
  /// <summary>
  /// prefix with a hyphen (-carrier) to reverse the order
  /// </summary>
  [JsonApiName("carrier")]
  Carrier,

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
  /// prefix with a hyphen (-number) to reverse the order
  /// </summary>
  [JsonApiName("number")]
  Number,

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
/// Queryable attributes for <see cref="Entities.PhoneNumber" />.
/// </summary>
public enum PhoneNumberQueryable
{
  /// <summary>
  /// Query on a specific carrier
  /// </summary>
  [JsonApiName("carrier")]
  Carrier,

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
  /// Query on a specific number
  /// </summary>
  [JsonApiName("number")]
  Number,

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

