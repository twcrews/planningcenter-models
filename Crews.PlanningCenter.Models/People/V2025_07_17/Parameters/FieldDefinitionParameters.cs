namespace Crews.PlanningCenter.Models.People.V2025_07_17.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.FieldDefinition" />.
/// </summary>
public enum FieldDefinitionIncludable
{
  /// <summary>
  /// include associated field_options
  /// </summary>
  [JsonApiName("field_options")]
  FieldOptions,

  /// <summary>
  /// include associated tab
  /// </summary>
  [JsonApiName("tab")]
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
  [JsonApiName("config")]
  Config,

  /// <summary>
  /// prefix with a hyphen (-data_type) to reverse the order
  /// </summary>
  [JsonApiName("data_type")]
  DataType,

  /// <summary>
  /// prefix with a hyphen (-deleted_at) to reverse the order
  /// </summary>
  [JsonApiName("deleted_at")]
  DeletedAt,

  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
  [JsonApiName("name")]
  Name,

  /// <summary>
  /// prefix with a hyphen (-sequence) to reverse the order
  /// </summary>
  [JsonApiName("sequence")]
  Sequence,

  /// <summary>
  /// prefix with a hyphen (-slug) to reverse the order
  /// </summary>
  [JsonApiName("slug")]
  Slug,

  /// <summary>
  /// prefix with a hyphen (-tab_id) to reverse the order
  /// </summary>
  [JsonApiName("tab_id")]
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
  [JsonApiName("config")]
  Config,

  /// <summary>
  /// Query on a specific data_type
  /// </summary>
  [JsonApiName("data_type")]
  DataType,

  /// <summary>
  /// Query on a specific deleted_at
  /// </summary>
  [JsonApiName("deleted_at")]
  DeletedAt,

  /// <summary>
  /// Query on a specific name
  /// </summary>
  [JsonApiName("name")]
  Name,

  /// <summary>
  /// Query on a specific sequence
  /// </summary>
  [JsonApiName("sequence")]
  Sequence,

  /// <summary>
  /// Query on a specific slug
  /// </summary>
  [JsonApiName("slug")]
  Slug,

  /// <summary>
  /// Query on a specific tab_id
  /// </summary>
  [JsonApiName("tab_id")]
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
  [JsonApiName("include_deleted")]
  IncludeDeleted,

}

