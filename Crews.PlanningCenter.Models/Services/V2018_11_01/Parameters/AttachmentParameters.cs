namespace Crews.PlanningCenter.Models.Services.V2018_11_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Attachment" />.
/// </summary>
public enum AttachmentIncludable
{
  /// <summary>
  /// include associated zooms
  /// </summary>
  Zooms,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.Attachment" />.
/// </summary>
public enum AttachmentOrderable
{
  /// <summary>
  /// prefix with a hyphen (-attachable_type) to reverse the order
  /// </summary>
  AttachableType,

  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-filename) to reverse the order
  /// </summary>
  Filename,

  /// <summary>
  /// prefix with a hyphen (-filetype) to reverse the order
  /// </summary>
  Filetype,

  /// <summary>
  /// prefix with a hyphen (-size) to reverse the order
  /// </summary>
  Size,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Attachment" />.
/// </summary>
public enum AttachmentQueryable
{
  /// <summary>
  /// Query on a specific licenses_purchased
  /// </summary>
  LicensesPurchased,

}

