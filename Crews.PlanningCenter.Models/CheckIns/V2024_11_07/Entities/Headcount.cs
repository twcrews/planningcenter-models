using System.Text.Json;

namespace Crews.PlanningCenter.Models.CheckIns.V2024_11_07.Entities;

/// <summary>
/// A tally of attendees for a given event time and attendance type.
/// If one does not exist, the count may have been zero.
/// </summary>
[JsonApiName("headcount")]
public record Headcount
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("total")]
  public int? Total { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("updated_at")]
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("created_at")]
  public DateTime? CreatedAt { get; init; }

}
