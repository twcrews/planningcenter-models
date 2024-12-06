using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2023_02_15.Entities;

/// <summary>
/// An inactive reason is a small bit of text indicating why a member is no longer active.
/// </summary>
[JsonApiName("inactive_reason")]
public record InactiveReason
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
