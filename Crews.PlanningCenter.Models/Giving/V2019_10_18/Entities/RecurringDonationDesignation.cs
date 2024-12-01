using System.Text.Json;

namespace Crews.PlanningCenter.Models.Giving.V2019_10_18.Entities;

/// <summary>
/// Much like a `Designation`, A `RecurringDonationDesignation` conveys how much of a `RecurringDonation` goes to a particular `Fund`.
/// 
/// </summary>
public record RecurringDonationDesignation
{
  /// <summary>
  /// The unique identifier for a recurring donation designation.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// Required. The number of cents that will be donated to a recurring donation designation's associated fund.
  /// </summary>
  public int? AmountCents { get; init; }

  /// <summary>
  /// The currency of `amount_cents`. Set to the currency of the associated organization.
  /// </summary>
  public string? AmountCurrency { get; init; }

}
