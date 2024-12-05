namespace Crews.PlanningCenter.Models.Calendar.V2018_08_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Attachment" />.
/// </summary>
public enum AttachmentIncludable
{
  /// <summary>
  /// include associated event
  /// </summary>
  Event,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.Attachment" />.
/// </summary>
public enum AttachmentOrderable
{
  /// <summary>
  /// prefix with a hyphen (-content_type) to reverse the order
  /// </summary>
  ContentType,

  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-description) to reverse the order
  /// </summary>
  Description,

  /// <summary>
  /// prefix with a hyphen (-file_size) to reverse the order
  /// </summary>
  FileSize,

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
/// Queryable attributes for <see cref="Entities.Attachment" />.
/// </summary>
public enum AttachmentQueryable
{
  /// <summary>
  /// Query on a specific content_type
  /// </summary>
  ContentType,

  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  CreatedAt,

  /// <summary>
  /// Query on a specific description
  /// </summary>
  Description,

  /// <summary>
  /// Query on a specific file_size
  /// </summary>
  FileSize,

  /// <summary>
  /// Query on a specific name
  /// </summary>
  Name,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  UpdatedAt,

}

