using System.Text.Json;

namespace Crews.PlanningCenter.Models.Calendar.V2022_07_07.Entities;

/// <summary>
/// A template for generating a report.
/// </summary>
[JsonApiName("report_template")]
public record ReportTemplate
{
  /// <summary>
  /// Unique identifier for the report
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// The contents of the report template
  /// </summary>
  [JsonApiName("body")]
  public string? Body { get; init; }

  /// <summary>
  /// UTC time at which the report was created
  /// </summary>
  [JsonApiName("created_at")]
  public string? CreatedAt { get; init; }

  /// <summary>
  /// A summarization of the report
  /// </summary>
  [JsonApiName("description")]
  public string? Description { get; init; }

  /// <summary>
  /// The title of the report
  /// </summary>
  [JsonApiName("title")]
  public string? Title { get; init; }

  /// <summary>
  /// UTC time at which the report was updated
  /// </summary>
  [JsonApiName("updated_at")]
  public string? UpdatedAt { get; init; }

}
