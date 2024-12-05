namespace Crews.PlanningCenter.Models.People.V2019_01_14.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Rule" />.
/// </summary>
public enum RuleIncludable
{
  /// <summary>
  /// include associated conditions
  /// </summary>
  Conditions,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.Rule" />.
/// </summary>
public enum RuleOrderable
{
  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-subset) to reverse the order
  /// </summary>
  Subset,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  UpdatedAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Rule" />.
/// </summary>
public enum RuleQueryable
{
  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  CreatedAt,

  /// <summary>
  /// Query on a specific subset
  /// </summary>
  Subset,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  UpdatedAt,

}

