using System.Text.Json;

namespace Crews.PlanningCenter.Models.Services.V2018_08_01.Entities;

/// <summary>
/// a skipped attachment
/// </summary>
public record SkippedAttachment
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public bool? Skipped { get; init; }

}