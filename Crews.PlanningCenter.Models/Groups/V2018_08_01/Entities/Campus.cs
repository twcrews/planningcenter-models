using System.Text.Json;

namespace Crews.PlanningCenter.Models.Groups.V2018_08_01.Entities;

/// <summary>
/// A campus as defined in Planning Center Accounts
/// </summary>
[JsonApiName("campus")]
public record Campus
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// The name of the campus
  /// </summary>
  [JsonApiName("name")]
  public string? Name { get; init; }

}
