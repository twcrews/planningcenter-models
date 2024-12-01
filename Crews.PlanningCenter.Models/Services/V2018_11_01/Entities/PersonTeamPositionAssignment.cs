using System.Text.Json;

namespace Crews.PlanningCenter.Models.Services.V2018_11_01.Entities;

/// <summary>
/// A person's assignment to a position within a team.
/// </summary>
public record PersonTeamPositionAssignment
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// Possible Values:
  /// "Every week"
  /// "Every other week"
  /// "Every 3rd week"
  /// "Every 4th week"
  /// "Every 5th week"
  /// "Every 6th week"
  /// "Once a month"
  /// "Twice a month"
  /// "Three times a month"
  /// "Choose Weeks"
  /// 
  /// </summary>
  public string? SchedulePreference { get; init; }

  /// <summary>
  /// When `schedule_preference` is set to "Choose Weeks" then this
  /// indicates which weeks are preferred (checked).
  /// 
  /// e.g. ['1', '3', '5'] to prefer odd numbered weeks.
  /// 
  /// </summary>
  public IEnumerable<JsonElement>? PreferredWeeks { get; init; }

}
