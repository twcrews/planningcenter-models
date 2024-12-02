using System.Text.Json;

namespace Crews.PlanningCenter.Models.Giving.V2018_08_01.Entities;

/// <summary>
/// Much like a <c>Designation</c>, A <c>RecurringDonationDesignation</c> conveys how much of a <c>RecurringDonation</c> goes to a particular <c>Fund</c>.
/// </summary>
public record RecurringDonationDesignation
{
  /// <summary>
  /// The unique identifier for a recurring donation designation.
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// Required. The number of cents that will be donated to a recurring donation designation's associated fund.
  /// </summary>
  public int? AmountCents { get; init; }

  /// <summary>
  /// The currency of <c>amount_cents</c>. Set to the currency of the associated organization.
  /// </summary>
  public string? AmountCurrency { get; init; }

}
