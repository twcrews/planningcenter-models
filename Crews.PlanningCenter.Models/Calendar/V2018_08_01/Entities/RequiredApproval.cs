using System.Text.Json;

namespace Crews.PlanningCenter.Models.Calendar.V2018_08_01.Entities;

/// <summary>
/// Represents the relationship between a Resource and a Resource Approval Group.
/// </summary>
[JsonApiName("required_approval")]
public record RequiredApproval
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

}
