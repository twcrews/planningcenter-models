using System.Text.Json;

namespace Crews.PlanningCenter.Models.Groups.V2023_07_10.Entities;

/// <summary>
/// Notes that group leaders can write for an event, generally related to attendance.
/// 
/// </summary>
public record EventNote
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// The body text of the note.
  /// 
  /// </summary>
  public string? Body { get; init; }

}
