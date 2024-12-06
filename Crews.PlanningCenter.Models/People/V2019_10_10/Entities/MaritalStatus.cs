using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2019_10_10.Entities;

/// <summary>
/// A martial status represents a member's current status, e.g. married, single, etc.
/// </summary>
[JsonApiName("marital_status")]
public record MaritalStatus
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
