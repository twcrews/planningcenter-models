using System.Text.Json;

namespace Crews.PlanningCenter.Models.Services.V2018_08_01.Entities;

/// <summary>
/// A person's assignment to a position within a team.
/// </summary>
[JsonApiName("person_team_position_assignment")]
public record PersonTeamPositionAssignment
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("created_at")]
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("updated_at")]
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
  /// </summary>
  [JsonApiName("schedule_preference")]
  public string? SchedulePreference { get; init; }

  /// <summary>
  /// When <c>schedule_preference</c> is set to "Choose Weeks" then this
  /// indicates which weeks are preferred (checked).
  /// 
  /// e.g. ['1', '3', '5'] to prefer odd numbered weeks.
  /// </summary>
  [JsonApiName("preferred_weeks")]
  public IEnumerable<JsonElement>? PreferredWeeks { get; init; }

}
