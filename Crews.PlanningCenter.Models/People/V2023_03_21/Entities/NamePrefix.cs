using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2023_03_21.Entities;

/// <summary>
/// A name prefix is one of Mr., Mrs., etc.
/// </summary>
[JsonApiName("name_prefix")]
public record NamePrefix
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
