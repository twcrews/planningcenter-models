namespace Crews.PlanningCenter.Models.People.V2021_08_17.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Condition" />.
/// </summary>
public enum ConditionIncludable
{
  /// <summary>
  /// include associated created_by
  /// </summary>
  [JsonApiName("created_by")]
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
  [JsonApiName("application")]
  Application,

  /// <summary>
  /// prefix with a hyphen (-comparison) to reverse the order
  /// </summary>
  [JsonApiName("comparison")]
  Comparison,

  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-definition_class) to reverse the order
  /// </summary>
  [JsonApiName("definition_class")]
  DefinitionClass,

  /// <summary>
  /// prefix with a hyphen (-definition_identifier) to reverse the order
  /// </summary>
  [JsonApiName("definition_identifier")]
  DefinitionIdentifier,

  /// <summary>
  /// prefix with a hyphen (-description) to reverse the order
  /// </summary>
  [JsonApiName("description")]
  Description,

  /// <summary>
  /// prefix with a hyphen (-settings) to reverse the order
  /// </summary>
  [JsonApiName("settings")]
  Settings,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  [JsonApiName("updated_at")]
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
  [JsonApiName("application")]
  Application,

  /// <summary>
  /// Query on a specific comparison
  /// </summary>
  [JsonApiName("comparison")]
  Comparison,

  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// Query on a specific definition_class
  /// </summary>
  [JsonApiName("definition_class")]
  DefinitionClass,

  /// <summary>
  /// Query on a specific definition_identifier
  /// </summary>
  [JsonApiName("definition_identifier")]
  DefinitionIdentifier,

  /// <summary>
  /// Query on a specific description
  /// </summary>
  [JsonApiName("description")]
  Description,

  /// <summary>
  /// Query on a specific settings
  /// </summary>
  [JsonApiName("settings")]
  Settings,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

}

