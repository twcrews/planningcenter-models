using System.Text.Json;

namespace Crews.PlanningCenter.Models.CheckIns.V2023_04_05.Entities;

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
public record CheckIn
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? FirstName { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? LastName { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? MedicalNotes { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public int? Number { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? SecurityCode { get; init; }

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
  public DateTime? CheckedOutAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? ConfirmedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? EmergencyContactName { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? EmergencyContactPhoneNumber { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public bool? OneTimeGuest { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Kind { get; init; }

}
