namespace Crews.PlanningCenter.Models.Calendar.V2021_07_20.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Attachment" />.
/// </summary>
public enum AttachmentIncludable
{
  /// <summary>
  /// include associated event
  /// </summary>
  [JsonApiName("event")]
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
  [JsonApiName("content_type")]
  ContentType,

  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-description) to reverse the order
  /// </summary>
  [JsonApiName("description")]
  Description,

  /// <summary>
  /// prefix with a hyphen (-file_size) to reverse the order
  /// </summary>
  [JsonApiName("file_size")]
  FileSize,

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
/// Queryable attributes for <see cref="Entities.Attachment" />.
/// </summary>
public enum AttachmentQueryable
{
  /// <summary>
  /// Query on a specific content_type
  /// </summary>
  [JsonApiName("content_type")]
  ContentType,

  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// Query on a specific description
  /// </summary>
  [JsonApiName("description")]
  Description,

  /// <summary>
  /// Query on a specific file_size
  /// </summary>
  [JsonApiName("file_size")]
  FileSize,

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

