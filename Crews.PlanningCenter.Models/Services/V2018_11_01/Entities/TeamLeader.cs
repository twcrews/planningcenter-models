namespace Crews.PlanningCenter.Models.Services.V2018_11_01.Entities;

/// <summary>
/// A leader of a specific Team in a Service Type.
/// </summary>
public record TeamLeader
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public bool? SendResponsesForAccepts { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public bool? SendResponsesForDeclines { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public bool? SendResponsesForBlockouts { get; init; }

}
