using System.Text.Json;

namespace Crews.PlanningCenter.Models.Services.V2018_08_01.Entities;

/// <summary>
/// A template for generating reports
/// </summary>
public record ReportTemplate
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Body { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Title { get; init; }

  /// <summary>
  /// Possible values: `ReportMatrix`, `ReportPeople`, `ReportPlan`
  /// </summary>
  public string? Type { get; init; }

  /// <summary>
  /// A template provided by Planning Center
  /// </summary>
  public bool? Default { get; init; }

}
