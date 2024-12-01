using System.Text.Json;

namespace Crews.PlanningCenter.Models.Giving.V2018_08_01.Entities;

/// <summary>
/// A record that links a `Refund` with a `Designation`
/// 
/// </summary>
public record DesignationRefund
{
  /// <summary>
  /// The unique identifier for a designation refund.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// The number of cents being refunded.
  /// </summary>
  public int? AmountCents { get; init; }

  /// <summary>
  /// The currency of `amount_cents`.
  /// </summary>
  public string? AmountCurrency { get; init; }

}
