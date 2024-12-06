using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2019_01_14.Entities;

/// <summary>
/// A name suffix is one of Sr., Jr., etc.
/// </summary>
[JsonApiName("name_suffix")]
public record NameSuffix
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("value")]
  public string? Value { get; init; }

}
