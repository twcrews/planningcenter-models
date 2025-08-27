namespace Crews.PlanningCenter.Models.People.V2020_04_06.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Tab" />.
/// </summary>
public enum TabIncludable
{
  /// <summary>
  /// include associated field_definitions
  /// </summary>
  [JsonApiName("field_definitions")]
  FieldDefinitions,

  /// <summary>
  /// include associated field_options
  /// </summary>
  [JsonApiName("field_options")]
  FieldOptions,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.Tab" />.
/// </summary>
public enum TabOrderable
{
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
}

/// <summary>
/// Queryable attributes for <see cref="Entities.Tab" />.
/// </summary>
public enum TabQueryable
{
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

}

/// <summary>
/// Filterable attributes for <see cref="Entities.Tab" />.
/// </summary>
public enum TabFilterable
{
  /// <summary>
  /// Filter by with_field_definitions.
  /// </summary>
  [JsonApiName("with_field_definitions")]
  WithFieldDefinitions,

}

