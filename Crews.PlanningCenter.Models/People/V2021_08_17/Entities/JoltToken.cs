using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2021_08_17.Entities;

/// <summary>
/// Planning Center does not provide a description for this resource.
/// </summary>
[JsonApiName("jolt_token")]
public record JoltToken
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

}
