using System.Text.Json;

namespace Crews.PlanningCenter.Models.Giving.V2019_10_18.Entities;

/// <summary>
/// A record that links a <c>Refund</c> with a <c>Designation</c>
/// </summary>
public record DesignationRefund
{
  /// <summary>
  /// The unique identifier for a designation refund.
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// The number of cents being refunded.
  /// </summary>
  public int? AmountCents { get; init; }

  /// <summary>
  /// The currency of <c>amount_cents</c>.
  /// </summary>
  public string? AmountCurrency { get; init; }

}
