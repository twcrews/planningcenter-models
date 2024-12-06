using System.Text.Json;

namespace Crews.PlanningCenter.Models.Services.V2018_08_01.Entities;

/// <summary>
/// A template for generating reports
/// </summary>
[JsonApiName("report_template")]
public record ReportTemplate
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("body")]
  public string? Body { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("title")]
  public string? Title { get; init; }

  /// <summary>
  /// Possible values: <c>ReportMatrix</c>, <c>ReportPeople</c>, <c>ReportPlan</c>
  /// </summary>
  [JsonApiName("type")]
  public string? Type { get; init; }

  /// <summary>
  /// A template provided by Planning Center
  /// </summary>
  [JsonApiName("default")]
  public bool? Default { get; init; }

}
