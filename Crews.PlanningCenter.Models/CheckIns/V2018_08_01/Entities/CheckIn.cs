using System.Text.Json;

namespace Crews.PlanningCenter.Models.CheckIns.V2018_08_01.Entities;

/// <summary>
/// An attendance record for an event.
/// 
/// If someone was checked out, `checked_out_at` will be present.
/// 
/// You can scope check-ins in a few ways:
/// 
/// - `regular`s, `guest`s, and `volunteer`s correspond to the option selected when checking in.
/// - `attendee`s are `regular`s and `guest`s together.
/// - `one_time_guest`s are check-ins which were created without a corresponding person record.
/// - `not_one_time_guest`s are check-ins which had a corresponding person record when they were created.
/// - `checked_out` are check-ins where `checked_out_at` is present (meaning they were checked out from a station).
/// - `first_time`s are check-ins which are the person's first for a given event. (Label-only visitors are not included here.)
/// 
/// </summary>
public record CheckIn
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Id { get; init; }

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
