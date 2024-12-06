namespace Crews.PlanningCenter.Models.Services.V2018_11_01.Parameters;

/// <summary>
/// Filterable attributes for <see cref="Entities.ReportTemplate" />.
/// </summary>
public enum ReportTemplateFilterable
{
  /// <summary>
  /// Filter by matrix.
  /// </summary>
  [JsonApiName("matrix")]
  Matrix,

  /// <summary>
  /// Filter by people.
  /// </summary>
  [JsonApiName("people")]
  People,

  /// <summary>
  /// Filter by plans.
  /// </summary>
  [JsonApiName("plans")]
  Plans,

  /// <summary>
  /// Filter by without_defaults.
  /// </summary>
  [JsonApiName("without_defaults")]
  WithoutDefaults,

}

