using System.Text.Json;

namespace Crews.PlanningCenter.Models.Services.V2018_08_01.Entities;

/// <summary>
/// A time in a plan.
/// </summary>
public record PlanTime
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
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Name { get; init; }

  /// <summary>
  /// Possible values are:
  /// 
  /// - rehearsal
  /// 
  /// - service
  /// 
  /// - other
  /// 
  /// </summary>
  public string? TimeType { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public bool? Recorded { get; init; }

  /// <summary>
  /// A Hash that maps a Team ID to a reminder value. If nothing is specified, no reminder is set for that team. A reminder value is an integer (0-7) equal to the number of days before the selected time a reminder should be sent.
  /// </summary>
  public IEnumerable<JsonElement>? TeamReminders { get; init; }

  /// <summary>
  /// Planned start time.
  /// </summary>
  public DateTime? StartsAt { get; init; }

  /// <summary>
  /// Planned end time.
  /// </summary>
  public DateTime? EndsAt { get; init; }

  /// <summary>
  /// Start time as recorded by Services LIVE.
  /// </summary>
  public DateTime? LiveStartsAt { get; init; }

  /// <summary>
  /// End time as recorded by Services LIVE.
  /// </summary>
  public DateTime? LiveEndsAt { get; init; }

}
