using System.Text.Json;

namespace Crews.PlanningCenter.Models.CheckIns.V2024_11_07.Entities;

/// <summary>
/// A place where people may check in to for a given event.
/// Some locations have <c>kind="Folder"</c>, which means that people
/// can't check-in here, but this location contains other locations.
/// You can get its contents from the <c>locations</c> attribute.
/// You can get a location's parent folder from the <c>parent</c> attribute.
/// (If it's not in a folder, <c>parent</c> will be empty.)
/// </summary>
[JsonApiName("location")]
public record Location
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("name")]
  public string? Name { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("kind")]
  public string? Kind { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("opened")]
  public bool? Opened { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("questions")]
  public string? Questions { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("age_min_in_months")]
  public int? AgeMinInMonths { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("age_max_in_months")]
  public int? AgeMaxInMonths { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("age_range_by")]
  public string? AgeRangeBy { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("age_on")]
  public DateOnly? AgeOn { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("child_or_adult")]
  public string? ChildOrAdult { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("effective_date")]
  public DateOnly? EffectiveDate { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("gender")]
  public string? Gender { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("grade_min")]
  public int? GradeMin { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("grade_max")]
  public int? GradeMax { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("max_occupancy")]
  public int? MaxOccupancy { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("min_volunteers")]
  public int? MinVolunteers { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("attendees_per_volunteer")]
  public int? AttendeesPerVolunteer { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("position")]
  public int? Position { get; init; }

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

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("milestone")]
  public string? Milestone { get; init; }

}
