using System.Text.Json;

namespace Crews.PlanningCenter.Models.Giving.V2018_08_01.Entities;

/// <summary>
/// Stored `PaymentMethod` information (`card` or `bank_account`) used by donors to make online `Donation`s.
/// 
/// `PaymentMethod` data is for informational purposes only and cannot be used to create charges through the API.
/// 
/// </summary>
public record PaymentMethod
{
  /// <summary>
  /// The unique identifier for a payment method.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// The date and time at which a payment method was created. Example: `2000-01-01T12:00:00Z`
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// The date and time at which a payment method was last updated. Example: `2000-01-01T12:00:00Z`
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// Determines whether or not the payment method is a card or bank account.
  /// 
  /// Possible values: `card`, `us_bank_account`, or `au_becs_debit`
  /// </summary>
  public string? MethodType { get; init; }

  /// <summary>
  /// For cards, either `credit`, `debit`, `prepaid`, or `unknown`. For bank accounts, either `checking` or `savings`.
  /// </summary>
  public string? MethodSubtype { get; init; }

  /// <summary>
  /// The last 4 digits of the payment method's number. For cards, this is the last 4 digits of the card number. For bank accounts, this is the last 4 digits of the bank account number. Note: In cases where we don't have all 4 digits on file, a `*` will be used to pad the number. For example: `*321`
  /// </summary>
  public string? Last4 { get; init; }

  /// <summary>
  /// For cards, this is the card brand (eg Visa, Mastercard, etc). For bank accounts, this is the bank name.
  /// </summary>
  public string? Brand { get; init; }

  /// <summary>
  /// For cards only. String representation of the expiration date in the `MM/YYYY` form (without leading zeros). Will be `null` for bank accounts.
  /// </summary>
  public DateOnly? Expiration { get; init; }

  /// <summary>
  /// For bank accounts only. Will be `null` for cards.
  /// </summary>
  public bool? Verified { get; init; }

}
