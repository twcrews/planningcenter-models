using System.Text.Json;

namespace Crews.PlanningCenter.Models.Giving.V2019_10_18.Entities;

/// <summary>
/// A <c>Designation</c> conveys how much of a <c>Donation</c> goes to a particular <c>Fund</c>.
/// 
/// <c>Designation</c> details are required when creating a <c>Donation</c>. If all of a <c>Donation</c> is going to a single <c>Fund</c>, it will only have one <c>Designation</c>. Similarly, to split a <c>Donation</c> between multiple <c>Fund</c>s, you can use multiple <c>Designation</c>s.
/// </summary>
[JsonApiName("designation")]
public record Designation
{
  /// <summary>
  /// The unique identifier for a designation.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Required. The number of cents being donated to a designation's associated fund.
  /// </summary>
  [JsonApiName("amount_cents")]
  public int? AmountCents { get; init; }

  /// <summary>
  /// The currency of <c>amount_cents</c>. Set to the currency of the associated organization.
  /// </summary>
  [JsonApiName("amount_currency")]
  public string? AmountCurrency { get; init; }

  /// <summary>
  /// The fee amount distributed to a donation's designation in proportion to the amount of the designation. This should either be 0 or a negative integer.
  /// </summary>
  [JsonApiName("fee_cents")]
  public int? FeeCents { get; init; }

}
