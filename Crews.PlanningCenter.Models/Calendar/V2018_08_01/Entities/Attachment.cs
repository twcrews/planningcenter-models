using System.Text.Json;

namespace Crews.PlanningCenter.Models.Calendar.V2018_08_01.Entities;

/// <summary>
/// An uploaded file attached to an event.
/// </summary>
[JsonApiName("attachment")]
public record Attachment
{
  /// <summary>
  /// Unique identifier for the attachment
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// MIME type of the attachment
  /// </summary>
  [JsonApiName("content_type")]
  public string? ContentType { get; init; }

  /// <summary>
  /// UTC time at which the attachment was created
  /// </summary>
  [JsonApiName("created_at")]
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Description of the attachment
  /// </summary>
  [JsonApiName("description")]
  public string? Description { get; init; }

  /// <summary>
  /// File size in bytes
  /// </summary>
  [JsonApiName("file_size")]
  public int? FileSize { get; init; }

  /// <summary>
  /// Set to the file name if not provided
  /// </summary>
  [JsonApiName("name")]
  public string? Name { get; init; }

  /// <summary>
  /// UTC time at which the attachment was updated
  /// </summary>
  [JsonApiName("updated_at")]
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// Path to where the attachment is stored
  /// </summary>
  [JsonApiName("url")]
  public string? Url { get; init; }

}
