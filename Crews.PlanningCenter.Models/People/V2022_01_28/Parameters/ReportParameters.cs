namespace Crews.PlanningCenter.Models.People.V2022_01_28.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Report" />.
/// </summary>
public enum ReportIncludable
{
  /// <summary>
  /// include associated created_by
  /// </summary>
  [JsonApiName("created_by")]
  CreatedBy,

  /// <summary>
  /// include associated updated_by
  /// </summary>
  [JsonApiName("updated_by")]
  UpdatedBy,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.Report" />.
/// </summary>
public enum ReportOrderable
{
  /// <summary>
  /// prefix with a hyphen (-body) to reverse the order
  /// </summary>
  [JsonApiName("body")]
  Body,

  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
  [JsonApiName("name")]
  Name,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Report" />.
/// </summary>
public enum ReportQueryable
{
  /// <summary>
  /// Query on a specific body
  /// </summary>
  [JsonApiName("body")]
  Body,

  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// Query on a specific name
  /// </summary>
  [JsonApiName("name")]
  Name,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

}

