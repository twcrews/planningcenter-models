namespace Crews.PlanningCenter.Models.People.V2020_07_22.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Tab" />.
/// </summary>
public enum TabIncludable
{
  /// <summary>
  /// include associated field_definitions
  /// </summary>
  FieldDefinitions,

  /// <summary>
  /// include associated field_options
  /// </summary>
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
  /// prefix with a hyphen (-slug) to reverse the order
  /// </summary>
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
  Name,

  /// <summary>
  /// Query on a specific sequence
  /// </summary>
  Sequence,

  /// <summary>
  /// Query on a specific slug
  /// </summary>
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
  WithFieldDefinitions,

}

