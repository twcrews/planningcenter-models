using System.Text.Json;

namespace Crews.PlanningCenter.Models.Giving.V2018_08_01.Entities;

/// <summary>
/// A <c>RecurringDonation</c> is represents a <c>Donation</c> that repeats on a set schedule (weekly, monthly, etc.)
/// 
/// Data for <c>RecurringDonation</c>s is read-only; they can not be created or edited through the API.
/// </summary>
[JsonApiName("recurring_donation")]
public record RecurringDonation
{
  /// <summary>
  /// The unique identifier for a recurring donation.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// The date and time at which a recurring donation was created. Example: <c>2000-01-01T12:00:00Z</c>
  /// </summary>
  [JsonApiName("created_at")]
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// The date and time at which a recurring donation was last updated. Example: <c>2000-01-01T12:00:00Z</c>
  /// </summary>
  [JsonApiName("updated_at")]
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// The date when the hold on a recurring donation with a status of <c>temporary_hold</c> will be released.
  /// </summary>
  [JsonApiName("release_hold_at")]
  public DateTime? ReleaseHoldAt { get; init; }

  /// <summary>
  /// The number of cents scheduled to be donated.
  /// </summary>
  [JsonApiName("amount_cents")]
  public int? AmountCents { get; init; }

  /// <summary>
  /// Determines if a recurring donation is active or on hold, and if on hold, the kind of hold that has been placed on it.
  /// 
  /// Possible values: <c>active</c>, <c>indefinite_hold</c> or <c>temporary_hold</c>.
  /// </summary>
  [JsonApiName("status")]
  public string? Status { get; init; }

  /// <summary>
  /// The date and time that the last donation was made for a recurring donation. Example: <c>2000-01-01T12:00:00Z</c>
  /// </summary>
  [JsonApiName("last_donation_received_at")]
  public DateTime? LastDonationReceivedAt { get; init; }

  /// <summary>
  /// The date that the next donation will be made for a recurring donation. Example: <c>2000-01-01T12:00:00Z</c>
  /// </summary>
  [JsonApiName("next_occurrence")]
  public DateTime? NextOccurrence { get; init; }

  /// <summary>
  /// JSON representation of the billing schedule. See the repeatable Ruby gem for more details on the structure and meaning: https://github.com/molawson/repeatable#time-expressions
  /// </summary>
  [JsonApiName("schedule")]
  public JsonElement? Schedule { get; init; }

  /// <summary>
  /// The currency of <c>amount_cents</c>.
  /// </summary>
  [JsonApiName("amount_currency")]
  public string? AmountCurrency { get; init; }

}
