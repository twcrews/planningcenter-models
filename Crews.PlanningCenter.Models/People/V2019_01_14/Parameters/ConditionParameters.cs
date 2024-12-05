namespace Crews.PlanningCenter.Models.People.V2019_01_14.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Condition" />.
/// </summary>
public enum ConditionIncludable
{
  /// <summary>
  /// include associated created_by
  /// </summary>
  CreatedBy,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.Condition" />.
/// </summary>
public enum ConditionOrderable
{
  /// <summary>
  /// prefix with a hyphen (-application) to reverse the order
  /// </summary>
  Application,

  /// <summary>
  /// prefix with a hyphen (-comparison) to reverse the order
  /// </summary>
  Comparison,

  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-definition_class) to reverse the order
  /// </summary>
  DefinitionClass,

  /// <summary>
  /// prefix with a hyphen (-definition_identifier) to reverse the order
  /// </summary>
  DefinitionIdentifier,

  /// <summary>
  /// prefix with a hyphen (-description) to reverse the order
  /// </summary>
  Description,

  /// <summary>
  /// prefix with a hyphen (-settings) to reverse the order
  /// </summary>
  Settings,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  UpdatedAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Condition" />.
/// </summary>
public enum ConditionQueryable
{
  /// <summary>
  /// Query on a specific application
  /// </summary>
  Application,

  /// <summary>
  /// Query on a specific comparison
  /// </summary>
  Comparison,

  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  CreatedAt,

  /// <summary>
  /// Query on a specific definition_class
  /// </summary>
  DefinitionClass,

  /// <summary>
  /// Query on a specific definition_identifier
  /// </summary>
  DefinitionIdentifier,

  /// <summary>
  /// Query on a specific description
  /// </summary>
  Description,

  /// <summary>
  /// Query on a specific settings
  /// </summary>
  Settings,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  UpdatedAt,

}

