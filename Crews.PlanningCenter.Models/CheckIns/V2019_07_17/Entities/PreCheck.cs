using System.Text.Json;

namespace Crews.PlanningCenter.Models.CheckIns.V2019_07_17.Entities;

/// <summary>
/// Planning Center does not provide a description for this resource.
/// </summary>
[JsonApiName("pre_check")]
public record PreCheck
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

}
