using System.Text.Json;

namespace Crews.PlanningCenter.Models.Giving.V2019_10_18.Entities;

/// <summary>
/// A record that links a <c>Refund</c> with a <c>Designation</c>
/// </summary>
[JsonApiName("designation_refund")]
public record DesignationRefund
{
  /// <summary>
  /// The unique identifier for a designation refund.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

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

}
