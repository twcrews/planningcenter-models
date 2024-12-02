using System.Text.Json;

namespace Crews.PlanningCenter.Models.Calendar.V2020_04_08.Entities;

/// <summary>
/// An uploaded file attached to an event.
/// </summary>
public record Attachment
{
  /// <summary>
  /// Unique identifier for the attachment
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// MIME type of the attachment
  /// </summary>
  public string? ContentType { get; init; }

  /// <summary>
  /// UTC time at which the attachment was created
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Description of the attachment
  /// </summary>
  public string? Description { get; init; }

  /// <summary>
  /// File size in bytes
  /// </summary>
  public int? FileSize { get; init; }

  /// <summary>
  /// Set to the file name if not provided
  /// </summary>
  public string? Name { get; init; }

  /// <summary>
  /// UTC time at which the attachment was updated
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// Path to where the attachment is stored
  /// </summary>
  public string? Url { get; init; }

}
