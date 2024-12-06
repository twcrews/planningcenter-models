using System.Text.Json;

namespace Crews.PlanningCenter.Models.Groups.V2023_07_10.Entities;

/// <summary>
/// Individual event attendance for a person.
/// </summary>
[JsonApiName("attendance")]
public record Attendance
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Whether or not the person attended the event.
  /// </summary>
  [JsonApiName("attended")]
  public bool? Attended { get; init; }

  /// <summary>
  /// The role of the person at the time of event.
  /// 
  /// Possible values: <c>member</c>, <c>leader</c>, <c>visitor</c>, or <c>applicant</c>
  /// </summary>
  [JsonApiName("role")]
  public string? Role { get; init; }

}
