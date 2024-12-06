using System.Text.Json;

namespace Crews.PlanningCenter.Models.Giving.V2018_08_01.Entities;

/// <summary>
/// Much like a <c>Designation</c>, A <c>RecurringDonationDesignation</c> conveys how much of a <c>RecurringDonation</c> goes to a particular <c>Fund</c>.
/// </summary>
[JsonApiName("recurring_donation_designation")]
public record RecurringDonationDesignation
{
  /// <summary>
  /// The unique identifier for a recurring donation designation.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Required. The number of cents that will be donated to a recurring donation designation's associated fund.
  /// </summary>
  [JsonApiName("amount_cents")]
  public int? AmountCents { get; init; }

  /// <summary>
  /// The currency of <c>amount_cents</c>. Set to the currency of the associated organization.
  /// </summary>
  [JsonApiName("amount_currency")]
  public string? AmountCurrency { get; init; }

}
