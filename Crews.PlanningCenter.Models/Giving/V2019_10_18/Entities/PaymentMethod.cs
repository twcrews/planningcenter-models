using System.Text.Json;

namespace Crews.PlanningCenter.Models.Giving.V2019_10_18.Entities;

/// <summary>
/// Stored <c>PaymentMethod</c> information (<c>card</c> or <c>bank_account</c>) used by donors to make online <c>Donation</c>s.
/// 
/// <c>PaymentMethod</c> data is for informational purposes only and cannot be used to create charges through the API.
/// </summary>
public record PaymentMethod
{
  /// <summary>
  /// The unique identifier for a payment method.
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// The date and time at which a payment method was created. Example: <c>2000-01-01T12:00:00Z</c>
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// The date and time at which a payment method was last updated. Example: <c>2000-01-01T12:00:00Z</c>
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// Determines whether or not the payment method is a card or bank account.
  /// 
  /// Possible values: <c>card</c>, <c>us_bank_account</c>, or <c>au_becs_debit</c>
  /// </summary>
  public string? MethodType { get; init; }

  /// <summary>
  /// For cards, either <c>credit</c>, <c>debit</c>, <c>prepaid</c>, or <c>unknown</c>. For bank accounts, either <c>checking</c> or <c>savings</c>.
  /// </summary>
  public string? MethodSubtype { get; init; }

  /// <summary>
  /// The last 4 digits of the payment method's number. For cards, this is the last 4 digits of the card number. For bank accounts, this is the last 4 digits of the bank account number. Note: In cases where we don't have all 4 digits on file, a <c>*</c> will be used to pad the number. For example: <c>*321</c>
  /// </summary>
  public string? Last4 { get; init; }

  /// <summary>
  /// For cards, this is the card brand (eg Visa, Mastercard, etc). For bank accounts, this is the bank name.
  /// </summary>
  public string? Brand { get; init; }

  /// <summary>
  /// For cards only. String representation of the expiration date in the <c>MM/YYYY</c> form (without leading zeros). Will be <c>null</c> for bank accounts.
  /// </summary>
  public DateOnly? Expiration { get; init; }

  /// <summary>
  /// For bank accounts only. Will be <c>null</c> for cards.
  /// </summary>
  public bool? Verified { get; init; }

}
