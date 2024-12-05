namespace Crews.PlanningCenter.Models.People.V2024_09_12.Parameters;

/// <summary>
/// Orderable attributes for <see cref="Entities.Email" />.
/// </summary>
public enum EmailOrderable
{
  /// <summary>
  /// prefix with a hyphen (-address) to reverse the order
  /// </summary>
  Address,

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
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
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
  Address,

  /// <summary>
  /// Query on a specific blocked
  /// </summary>
  Blocked,

  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  CreatedAt,

  /// <summary>
  /// Query on a specific location
  /// </summary>
  Location,

  /// <summary>
  /// Query on a specific primary
  /// </summary>
  Primary,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  UpdatedAt,

}

