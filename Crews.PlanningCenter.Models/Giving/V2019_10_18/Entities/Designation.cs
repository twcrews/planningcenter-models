using System.Text.Json;

namespace Crews.PlanningCenter.Models.Giving.V2019_10_18.Entities;

/// <summary>
/// A `Designation` conveys how much of a `Donation` goes to a particular `Fund`.
/// 
/// `Designation` details are required when creating a `Donation`. If all of a `Donation` is going to a single `Fund`, it will only have one `Designation`. Similarly, to split a `Donation` between multiple `Fund`s, you can use multiple `Designation`s.
/// 
/// </summary>
public record Designation
{
  /// <summary>
  /// The unique identifier for a designation.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// Required. The number of cents being donated to a designation's associated fund.
  /// </summary>
  public int? AmountCents { get; init; }

  /// <summary>
  /// The currency of `amount_cents`. Set to the currency of the associated organization.
  /// </summary>
  public string? AmountCurrency { get; init; }

  /// <summary>
  /// The fee amount distributed to a donation's designation in proportion to the amount of the designation. This should either be 0 or a negative integer.
  /// </summary>
  public int? FeeCents { get; init; }

}
