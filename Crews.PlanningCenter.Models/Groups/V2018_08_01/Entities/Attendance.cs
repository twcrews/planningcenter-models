using System.Text.Json;

namespace Crews.PlanningCenter.Models.Groups.V2018_08_01.Entities;

/// <summary>
/// Individual event attendance for a person.
/// 
/// </summary>
public record Attendance
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// Whether or not the person attended the event.
  /// 
  /// </summary>
  public bool? Attended { get; init; }

  /// <summary>
  /// The role of the person at the time of event.
  /// 
  /// 
  /// Possible values: `member`, `leader`, `visitor`, or `applicant`
  /// </summary>
  public string? Role { get; init; }

}
