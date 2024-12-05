namespace Crews.PlanningCenter.Models.People.V2024_09_12.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.FieldDatum" />.
/// </summary>
public enum FieldDatumIncludable
{
  /// <summary>
  /// include associated field_definition
  /// </summary>
  FieldDefinition,

  /// <summary>
  /// include associated field_option
  /// </summary>
  FieldOption,

  /// <summary>
  /// include associated tab
  /// </summary>
  Tab,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.FieldDatum" />.
/// </summary>
public enum FieldDatumOrderable
{
  /// <summary>
  /// prefix with a hyphen (-file) to reverse the order
  /// </summary>
  File,

  /// <summary>
  /// prefix with a hyphen (-file_content_type) to reverse the order
  /// </summary>
  FileContentType,

  /// <summary>
  /// prefix with a hyphen (-file_name) to reverse the order
  /// </summary>
  FileName,

  /// <summary>
  /// prefix with a hyphen (-file_size) to reverse the order
  /// </summary>
  FileSize,

  /// <summary>
  /// prefix with a hyphen (-value) to reverse the order
  /// </summary>
  Value,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.FieldDatum" />.
/// </summary>
public enum FieldDatumQueryable
{
  /// <summary>
  /// Query on a specific file
  /// </summary>
  File,

  /// <summary>
  /// Query on a specific file_content_type
  /// </summary>
  FileContentType,

  /// <summary>
  /// Query on a specific file_name
  /// </summary>
  FileName,

  /// <summary>
  /// Query on a specific file_size
  /// </summary>
  FileSize,

  /// <summary>
  /// Query on a specific value
  /// </summary>
  Value,

}

