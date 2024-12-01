using System.Text.Json;

namespace Crews.PlanningCenter.Models.Giving.V2018_08_01.Entities;

/// <summary>
/// A `Refund` record holds information pertaining to a refunded `Donation`.
/// 
/// </summary>
public record Refund
{
  /// <summary>
  /// The unique identifier for a refund.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// The date and time at which a refund was created. Example: `2000-01-01T12:00:00Z`
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// The date and time at which a refund was last updated. Example: `2000-01-01T12:00:00Z`
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// The number of cents being refunded.
  /// </summary>
  public int? AmountCents { get; init; }

  /// <summary>
  /// The currency of `amount_cents`.
  /// </summary>
  public string? AmountCurrency { get; init; }

  /// <summary>
  /// The payment processing fee returned by Stripe, if any.
  /// </summary>
  public int? FeeCents { get; init; }

  /// <summary>
  /// The date and time at which a refund was processed. Example: `2000-01-01T12:00:00Z`
  /// </summary>
  public DateTime? RefundedAt { get; init; }

  /// <summary>
  /// The currency of `fee_cents`.
  /// </summary>
  public string? FeeCurrency { get; init; }

}
