namespace Crews.PlanningCenter.Models.People.V2023_03_21.Parameters;

/// <summary>
/// Orderable attributes for <see cref="Entities.PhoneNumber" />.
/// </summary>
public enum PhoneNumberOrderable
{
  /// <summary>
  /// prefix with a hyphen (-carrier) to reverse the order
  /// </summary>
  Carrier,

  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-location) to reverse the order
  /// </summary>
  Location,

  /// <summary>
  /// prefix with a hyphen (-number) to reverse the order
  /// </summary>
  Number,

  /// <summary>
  /// prefix with a hyphen (-primary) to reverse the order
  /// </summary>
  Primary,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
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
  Carrier,

  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  CreatedAt,

  /// <summary>
  /// Query on a specific location
  /// </summary>
  Location,

  /// <summary>
  /// Query on a specific number
  /// </summary>
  Number,

  /// <summary>
  /// Query on a specific primary
  /// </summary>
  Primary,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  UpdatedAt,

}

