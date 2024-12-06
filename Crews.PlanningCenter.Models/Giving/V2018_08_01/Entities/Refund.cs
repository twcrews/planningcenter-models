using System.Text.Json;

namespace Crews.PlanningCenter.Models.Giving.V2018_08_01.Entities;

/// <summary>
/// A <c>Refund</c> record holds information pertaining to a refunded <c>Donation</c>.
/// </summary>
[JsonApiName("refund")]
public record Refund
{
  /// <summary>
  /// The unique identifier for a refund.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// The date and time at which a refund was created. Example: <c>2000-01-01T12:00:00Z</c>
  /// </summary>
  [JsonApiName("created_at")]
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// The date and time at which a refund was last updated. Example: <c>2000-01-01T12:00:00Z</c>
  /// </summary>
  [JsonApiName("updated_at")]
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// The number of cents being refunded.
  /// </summary>
  [JsonApiName("amount_cents")]
  public int? AmountCents { get; init; }

  /// <summary>
  /// The currency of <c>amount_cents</c>.
  /// </summary>
  [JsonApiName("amount_currency")]
  public string? AmountCurrency { get; init; }

  /// <summary>
  /// The payment processing fee returned by Stripe, if any.
  /// </summary>
  [JsonApiName("fee_cents")]
  public int? FeeCents { get; init; }

  /// <summary>
  /// The date and time at which a refund was processed. Example: <c>2000-01-01T12:00:00Z</c>
  /// </summary>
  [JsonApiName("refunded_at")]
  public DateTime? RefundedAt { get; init; }

  /// <summary>
  /// The currency of <c>fee_cents</c>.
  /// </summary>
  [JsonApiName("fee_currency")]
  public string? FeeCurrency { get; init; }

}
