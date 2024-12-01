using System.Text.Json;

namespace Crews.PlanningCenter.Models.Giving.V2018_08_01.Entities;

/// <summary>
/// A `Donation` record corresponds to a gift given to an `Organization` at a particular point in time.
/// 
/// `Donation`s are added by first associating them to a `Batch` of donations, and then committing the `Batch`. When adding a `Donation` to an already-committed `Batch`, the `Donation` will automatically be committed as well, and immediately added to the donor's online history.
/// 
/// </summary>
public record Donation
{
  /// <summary>
  /// The unique identifier for a donation.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// The date and time at which a donation was created. Example: `2000-01-01T12:00:00Z`
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// The date and time at which a donation was last updated. Example: `2000-01-01T12:00:00Z`
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// For cards, this will be the card subtype. Will be `null` for other payment method types.
  /// 
  /// Possible values: `credit`, `debit`, `prepaid`, or `unknown`
  /// </summary>
  public string? PaymentMethodSub { get; init; }

  /// <summary>
  /// The last 4 digits of a donation's payment method number. For cards, this is the last 4 digits of the card number. For bank accounts, this is the last 4 digits of the bank account number. For cash and check donations, this should be `null`. Note: In cases where we don't have all 4 digits on file, a `*` will be used to pad the number. For example: `*321`
  /// </summary>
  public string? PaymentLast4 { get; init; }

  /// <summary>
  /// For cards, this is the card brand (eg Visa, Mastercard, etc). For checks and bank accounts, this is the bank name. For cash donations, this should be `null`.
  /// </summary>
  public string? PaymentBrand { get; init; }

  /// <summary>
  /// The check number for donations made by check.
  /// </summary>
  public int? PaymentCheckNumber { get; init; }

  /// <summary>
  /// The check date for donations made by check. Example: `2000-01-01`
  /// </summary>
  public DateOnly? PaymentCheckDatedAt { get; init; }

  /// <summary>
  /// The fee to process a donation. This should either be 0 or a negative integer. For a donation processed by Giving via Stripe, this is the amount the associated organization paid Stripe to process it. For donations not processed by Stripe, this can be used to record fees from other systems. Note: while `amount_cents` is assigned via a donation's designations, `fee_cents` is set here, and used by Giving to distribute fees across all designations in proportion to the amount of each designation.
  /// </summary>
  public int? FeeCents { get; init; }

  /// <summary>
  /// Required. The payment method used to make a donation.
  /// 
  /// Possible values: `ach`, `cash`, `check`, or `card`
  /// </summary>
  public string? PaymentMethod { get; init; }

  /// <summary>
  /// The date and time at which a donation was received. For card and ACH donations processed by Stripe, this is the moment when the donation was created in Giving. For batch donations, this is a customizable value that can be set via the Giving UI or API to any date. This allows for batch donations recieved on a previous day to be dated in the past, as well as for postdated checks to have a date in the future. It is important to ensure that this attribute is set accurately, as this is the date used to filter donations in the Giving admin UI. When creating new donations via the API, this attribute will default to the current date and time. Example: `2000-01-01T12:00:00Z`
  /// </summary>
  public DateTime? ReceivedAt { get; init; }

  /// <summary>
  /// The number of cents being donated. Derived from the total of all of a donation's associated designation's `amount_cents` values.
  /// </summary>
  public int? AmountCents { get; init; }

  /// <summary>
  /// For Stripe donations, this is the payment status. For batch donations, `pending` means that the donation has not yet been committed, whereas `succeeded` refers to a committed donation.
  /// 
  /// Possible values: `pending`, `succeeded`, or `failed`
  /// </summary>
  public string? PaymentStatus { get; init; }

  /// <summary>
  /// The date and time at which a donation was completely processed. For card and ACH donations processed by Stripe, this is the moment when the donation was marked as fully processed by Stripe. For committed batch donations, this is the moment that the batch was committed. For uncommitted batch donations, this should return `null`. Example: `2000-01-01T12:00:00Z`
  /// </summary>
  public DateTime? CompletedAt { get; init; }

  /// <summary>
  /// A boolean indicating whether the donor chose to cover the Stripe processing fee for this donation.Note that `fee_covered` can only be true for donations processed through Stripe.
  /// </summary>
  public bool? FeeCovered { get; init; }

  /// <summary>
  /// The currency of `amount_cents`. Based on the organization's currency.
  /// </summary>
  public string? AmountCurrency { get; init; }

  /// <summary>
  /// The currency of `fee_cents`. Based on the organization's currency.
  /// </summary>
  public string? FeeCurrency { get; init; }

  /// <summary>
  /// Returns `true` if a donation has been refunded, or `false` if it hasn't.
  /// </summary>
  public bool? Refunded { get; init; }

  /// <summary>
  /// A boolean indicating whether this donation can be refunded via the API. Note that for some donations, this may be false, even though the donation _can_ be refunded in the UI.
  /// </summary>
  public bool? Refundable { get; init; }

}
