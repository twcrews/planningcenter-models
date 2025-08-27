using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2025_03_20.Entities;

/// <summary>
/// A ServiceTime Resource
/// </summary>
[JsonApiName("service_time")]
public record ServiceTime
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("start_time")]
  public int? StartTime { get; init; }

  /// <summary>
  /// Possible values: <c>sunday</c>, <c>monday</c>, <c>tuesday</c>, <c>wednesday</c>, <c>thursday</c>, <c>friday</c>, or <c>saturday</c>
  /// </summary>
  [JsonApiName("day")]
  public string? Day { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("description")]
  public string? Description { get; init; }

}
