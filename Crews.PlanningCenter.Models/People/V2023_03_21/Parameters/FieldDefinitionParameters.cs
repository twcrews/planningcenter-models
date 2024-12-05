namespace Crews.PlanningCenter.Models.People.V2023_03_21.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.FieldDefinition" />.
/// </summary>
public enum FieldDefinitionIncludable
{
  /// <summary>
  /// include associated field_options
  /// </summary>
  FieldOptions,

  /// <summary>
  /// include associated tab
  /// </summary>
  Tab,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.FieldDefinition" />.
/// </summary>
public enum FieldDefinitionOrderable
{
  /// <summary>
  /// prefix with a hyphen (-config) to reverse the order
  /// </summary>
  Config,

  /// <summary>
  /// prefix with a hyphen (-data_type) to reverse the order
  /// </summary>
  DataType,

  /// <summary>
  /// prefix with a hyphen (-deleted_at) to reverse the order
  /// </summary>
  DeletedAt,

  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
  Name,

  /// <summary>
  /// prefix with a hyphen (-sequence) to reverse the order
  /// </summary>
  Sequence,

  /// <summary>
  /// prefix with a hyphen (-slug) to reverse the order
  /// </summary>
  Slug,

  /// <summary>
  /// prefix with a hyphen (-tab_id) to reverse the order
  /// </summary>
  TabId,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.FieldDefinition" />.
/// </summary>
public enum FieldDefinitionQueryable
{
  /// <summary>
  /// Query on a specific config
  /// </summary>
  Config,

  /// <summary>
  /// Query on a specific data_type
  /// </summary>
  DataType,

  /// <summary>
  /// Query on a specific deleted_at
  /// </summary>
  DeletedAt,

  /// <summary>
  /// Query on a specific name
  /// </summary>
  Name,

  /// <summary>
  /// Query on a specific sequence
  /// </summary>
  Sequence,

  /// <summary>
  /// Query on a specific slug
  /// </summary>
  Slug,

  /// <summary>
  /// Query on a specific tab_id
  /// </summary>
  TabId,

}

/// <summary>
/// Filterable attributes for <see cref="Entities.FieldDefinition" />.
/// </summary>
public enum FieldDefinitionFilterable
{
  /// <summary>
  /// Filter by include_deleted.
  /// </summary>
  IncludeDeleted,

}

