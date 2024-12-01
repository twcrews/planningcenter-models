using System.Text.Json;

namespace Crews.PlanningCenter.Models.Giving.V2019_10_18.Entities;

/// <summary>
/// A `RecurringDonation` is represents a `Donation` that repeats on a set schedule (weekly, monthly, etc.)
/// 
/// Data for `RecurringDonation`s is read-only; they can not be created or edited through the API.
/// 
/// </summary>
public record RecurringDonation
{
  /// <summary>
  /// The unique identifier for a recurring donation.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// The date and time at which a recurring donation was created. Example: `2000-01-01T12:00:00Z`
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// The date and time at which a recurring donation was last updated. Example: `2000-01-01T12:00:00Z`
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// The date when the hold on a recurring donation with a status of `temporary_hold` will be released.
  /// </summary>
  public DateTime? ReleaseHoldAt { get; init; }

  /// <summary>
  /// The number of cents scheduled to be donated.
  /// </summary>
  public int? AmountCents { get; init; }

  /// <summary>
  /// Determines if a recurring donation is active or on hold, and if on hold, the kind of hold that has been placed on it.
  /// 
  /// Possible values: `active`, `indefinite_hold` or `temporary_hold`.
  /// </summary>
  public string? Status { get; init; }

  /// <summary>
  /// The date and time that the last donation was made for a recurring donation. Example: `2000-01-01T12:00:00Z`
  /// </summary>
  public DateTime? LastDonationReceivedAt { get; init; }

  /// <summary>
  /// The date that the next donation will be made for a recurring donation. Example: `2000-01-01T12:00:00Z`
  /// </summary>
  public DateTime? NextOccurrence { get; init; }

  /// <summary>
  /// JSON representation of the billing schedule. See the repeatable Ruby gem for more details on the structure and meaning: https://github.com/molawson/repeatable#time-expressions
  /// </summary>
  public JsonElement? Schedule { get; init; }

  /// <summary>
  /// The currency of `amount_cents`.
  /// </summary>
  public string? AmountCurrency { get; init; }

}