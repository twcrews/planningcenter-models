namespace Crews.PlanningCenter.Models.Giving.V2019_10_18.Entities;

/// <summary>
/// A <c>Refund</c> record holds information pertaining to a refunded <c>Donation</c>.
/// </summary>
public record Refund
{
  /// <summary>
  /// The unique identifier for a refund.
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// The date and time at which a refund was created. Example: <c>2000-01-01T12:00:00Z</c>
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// The date and time at which a refund was last updated. Example: <c>2000-01-01T12:00:00Z</c>
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// The number of cents being refunded.
  /// </summary>
  public int? AmountCents { get; init; }

  /// <summary>
  /// The currency of <c>amount_cents</c>.
  /// </summary>
  public string? AmountCurrency { get; init; }

  /// <summary>
  /// The payment processing fee returned by Stripe, if any.
  /// </summary>
  public int? FeeCents { get; init; }

  /// <summary>
  /// The date and time at which a refund was processed. Example: <c>2000-01-01T12:00:00Z</c>
  /// </summary>
  public DateTime? RefundedAt { get; init; }

  /// <summary>
  /// The currency of <c>fee_cents</c>.
  /// </summary>
  public string? FeeCurrency { get; init; }

}
