namespace Crews.PlanningCenter.Models.Calendar.V2022_07_07.Entities;

/// <summary>
/// A template for generating a report.
/// </summary>
public record ReportTemplate
{
  /// <summary>
  /// Unique identifier for the report
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// The contents of the report template
  /// </summary>
  public string? Body { get; init; }

  /// <summary>
  /// UTC time at which the report was created
  /// </summary>
  public string? CreatedAt { get; init; }

  /// <summary>
  /// A summarization of the report
  /// </summary>
  public string? Description { get; init; }

  /// <summary>
  /// The title of the report
  /// </summary>
  public string? Title { get; init; }

  /// <summary>
  /// UTC time at which the report was updated
  /// </summary>
  public string? UpdatedAt { get; init; }

}
