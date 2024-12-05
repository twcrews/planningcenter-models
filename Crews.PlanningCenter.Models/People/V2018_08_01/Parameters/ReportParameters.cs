namespace Crews.PlanningCenter.Models.People.V2018_08_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Report" />.
/// </summary>
public enum ReportIncludable
{
  /// <summary>
  /// include associated created_by
  /// </summary>
  CreatedBy,

  /// <summary>
  /// include associated updated_by
  /// </summary>
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
  Body,

  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
  Name,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
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
  Body,

  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  CreatedAt,

  /// <summary>
  /// Query on a specific name
  /// </summary>
  Name,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  UpdatedAt,

}

