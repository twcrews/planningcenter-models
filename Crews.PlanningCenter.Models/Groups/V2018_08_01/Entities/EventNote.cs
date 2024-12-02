namespace Crews.PlanningCenter.Models.Groups.V2018_08_01.Entities;

/// <summary>
/// Notes that group leaders can write for an event, generally related to attendance.
/// </summary>
public record EventNote
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// The body text of the note.
  /// </summary>
  public string? Body { get; init; }

}
