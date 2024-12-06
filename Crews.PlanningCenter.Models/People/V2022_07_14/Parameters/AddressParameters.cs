namespace Crews.PlanningCenter.Models.People.V2022_07_14.Parameters;

/// <summary>
/// Orderable attributes for <see cref="Entities.Address" />.
/// </summary>
public enum AddressOrderable
{
  /// <summary>
  /// prefix with a hyphen (-city) to reverse the order
  /// </summary>
  [JsonApiName("city")]
  City,

  /// <summary>
  /// prefix with a hyphen (-country_code) to reverse the order
  /// </summary>
  [JsonApiName("country_code")]
  CountryCode,

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
  /// prefix with a hyphen (-state) to reverse the order
  /// </summary>
  [JsonApiName("state")]
  State,

  /// <summary>
  /// prefix with a hyphen (-street) to reverse the order
  /// </summary>
  [JsonApiName("street")]
  Street,

  /// <summary>
  /// prefix with a hyphen (-street_line_1) to reverse the order
  /// </summary>
  [JsonApiName("street_line_1")]
  StreetLine1,

  /// <summary>
  /// prefix with a hyphen (-street_line_2) to reverse the order
  /// </summary>
  [JsonApiName("street_line_2")]
  StreetLine2,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

  /// <summary>
  /// prefix with a hyphen (-zip) to reverse the order
  /// </summary>
  [JsonApiName("zip")]
  Zip,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Address" />.
/// </summary>
public enum AddressQueryable
{
  /// <summary>
  /// Query on a specific city
  /// </summary>
  [JsonApiName("city")]
  City,

  /// <summary>
  /// Query on a specific country_code
  /// </summary>
  [JsonApiName("country_code")]
  CountryCode,

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
  /// Query on a specific state
  /// </summary>
  [JsonApiName("state")]
  State,

  /// <summary>
  /// Query on a specific street
  /// </summary>
  [JsonApiName("street")]
  Street,

  /// <summary>
  /// Query on a specific zip
  /// </summary>
  [JsonApiName("zip")]
  Zip,

}

