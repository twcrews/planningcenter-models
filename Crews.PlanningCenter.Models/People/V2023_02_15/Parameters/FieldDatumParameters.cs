namespace Crews.PlanningCenter.Models.People.V2023_02_15.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.FieldDatum" />.
/// </summary>
public enum FieldDatumIncludable
{
  /// <summary>
  /// include associated field_definition
  /// </summary>
  [JsonApiName("field_definition")]
  FieldDefinition,

  /// <summary>
  /// include associated field_option
  /// </summary>
  [JsonApiName("field_option")]
  FieldOption,

  /// <summary>
  /// include associated tab
  /// </summary>
  [JsonApiName("tab")]
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
  [JsonApiName("file")]
  File,

  /// <summary>
  /// prefix with a hyphen (-file_content_type) to reverse the order
  /// </summary>
  [JsonApiName("file_content_type")]
  FileContentType,

  /// <summary>
  /// prefix with a hyphen (-file_name) to reverse the order
  /// </summary>
  [JsonApiName("file_name")]
  FileName,

  /// <summary>
  /// prefix with a hyphen (-file_size) to reverse the order
  /// </summary>
  [JsonApiName("file_size")]
  FileSize,

  /// <summary>
  /// prefix with a hyphen (-value) to reverse the order
  /// </summary>
  [JsonApiName("value")]
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
  [JsonApiName("file")]
  File,

  /// <summary>
  /// Query on a specific file_content_type
  /// </summary>
  [JsonApiName("file_content_type")]
  FileContentType,

  /// <summary>
  /// Query on a specific file_name
  /// </summary>
  [JsonApiName("file_name")]
  FileName,

  /// <summary>
  /// Query on a specific file_size
  /// </summary>
  [JsonApiName("file_size")]
  FileSize,

  /// <summary>
  /// Query on a specific value
  /// </summary>
  [JsonApiName("value")]
  Value,

}

