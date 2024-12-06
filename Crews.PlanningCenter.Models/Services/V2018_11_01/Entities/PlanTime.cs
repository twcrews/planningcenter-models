using System.Text.Json;

namespace Crews.PlanningCenter.Models.Services.V2018_11_01.Entities;

/// <summary>
/// A time in a plan.
/// </summary>
[JsonApiName("plan_time")]
public record PlanTime
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
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("name")]
  public string? Name { get; init; }

  /// <summary>
  /// Possible values are:
  /// 
  /// - rehearsal
  /// 
  /// - service
  /// 
  /// - other
  /// </summary>
  [JsonApiName("time_type")]
  public string? TimeType { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("recorded")]
  public bool? Recorded { get; init; }

  /// <summary>
  /// A Hash that maps a Team ID to a reminder value. If nothing is specified, no reminder is set for that team. A reminder value is an integer (0-7) equal to the number of days before the selected time a reminder should be sent.
  /// </summary>
  [JsonApiName("team_reminders")]
  public IEnumerable<JsonElement>? TeamReminders { get; init; }

  /// <summary>
  /// Planned start time.
  /// </summary>
  [JsonApiName("starts_at")]
  public DateTime? StartsAt { get; init; }

  /// <summary>
  /// Planned end time.
  /// </summary>
  [JsonApiName("ends_at")]
  public DateTime? EndsAt { get; init; }

  /// <summary>
  /// Start time as recorded by Services LIVE.
  /// </summary>
  [JsonApiName("live_starts_at")]
  public DateTime? LiveStartsAt { get; init; }

  /// <summary>
  /// End time as recorded by Services LIVE.
  /// </summary>
  [JsonApiName("live_ends_at")]
  public DateTime? LiveEndsAt { get; init; }

}
