namespace Crews.PlanningCenter.Models.People.V2020_04_06.Parameters;

/// <summary>
/// Orderable attributes for <see cref="Entities.Address" />.
/// </summary>
public enum AddressOrderable
{
  /// <summary>
  /// prefix with a hyphen (-city) to reverse the order
  /// </summary>
  City,

  /// <summary>
  /// prefix with a hyphen (-country_code) to reverse the order
  /// </summary>
  CountryCode,

  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-location) to reverse the order
  /// </summary>
  Location,

  /// <summary>
  /// prefix with a hyphen (-primary) to reverse the order
  /// </summary>
  Primary,

  /// <summary>
  /// prefix with a hyphen (-state) to reverse the order
  /// </summary>
  State,

  /// <summary>
  /// prefix with a hyphen (-street) to reverse the order
  /// </summary>
  Street,

  /// <summary>
  /// prefix with a hyphen (-street_line_1) to reverse the order
  /// </summary>
  StreetLine1,

  /// <summary>
  /// prefix with a hyphen (-street_line_2) to reverse the order
  /// </summary>
  StreetLine2,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  UpdatedAt,

  /// <summary>
  /// prefix with a hyphen (-zip) to reverse the order
  /// </summary>
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
  City,

  /// <summary>
  /// Query on a specific country_code
  /// </summary>
  CountryCode,

  /// <summary>
  /// Query on a specific location
  /// </summary>
  Location,

  /// <summary>
  /// Query on a specific primary
  /// </summary>
  Primary,

  /// <summary>
  /// Query on a specific state
  /// </summary>
  State,

  /// <summary>
  /// Query on a specific street
  /// </summary>
  Street,

  /// <summary>
  /// Query on a specific zip
  /// </summary>
  Zip,

}

