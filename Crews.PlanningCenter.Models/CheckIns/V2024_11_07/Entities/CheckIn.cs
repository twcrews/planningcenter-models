using System.Text.Json;

namespace Crews.PlanningCenter.Models.CheckIns.V2024_11_07.Entities;

/// <summary>
/// An attendance record for an event.
/// 
/// If someone was checked out, <c>checked_out_at</c> will be present.
/// 
/// You can scope check-ins in a few ways:
/// 
/// - <c>regular</c>s, <c>guest</c>s, and <c>volunteer</c>s correspond to the option selected when checking in.
/// - <c>attendee</c>s are <c>regular</c>s and <c>guest</c>s together.
/// - <c>one_time_guest</c>s are check-ins which were created without a corresponding person record.
/// - <c>not_one_time_guest</c>s are check-ins which had a corresponding person record when they were created.
/// - <c>checked_out</c> are check-ins where <c>checked_out_at</c> is present (meaning they were checked out from a station).
/// - <c>first_time</c>s are check-ins which are the person's first for a given event. (Label-only visitors are not included here.)
/// </summary>
[JsonApiName("check_in")]
public record CheckIn
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("first_name")]
  public string? FirstName { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("last_name")]
  public string? LastName { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("medical_notes")]
  public string? MedicalNotes { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("number")]
  public int? Number { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("security_code")]
  public string? SecurityCode { get; init; }

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
  [JsonApiName("checked_out_at")]
  public DateTime? CheckedOutAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("confirmed_at")]
  public DateTime? ConfirmedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("emergency_contact_name")]
  public string? EmergencyContactName { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("emergency_contact_phone_number")]
  public string? EmergencyContactPhoneNumber { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("one_time_guest")]
  public bool? OneTimeGuest { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("kind")]
  public string? Kind { get; init; }

}
