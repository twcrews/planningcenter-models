using System.Text.Json;

namespace Crews.PlanningCenter.Models.Giving.V2019_10_18.Entities;

/// <summary>
/// An <c>InKindDonation</c> record represents a non-cash gift given to an <c>Organization</c> at a specific time.
/// 
/// These include items like furniture, vehicles, services, or stocks. <c>InKindDonations</c> do not trigger
/// acknowledgment letter emails via the API — these must be sent from the Giving Admin UI.
/// 
/// <a href="https://pcogiving.zendesk.com/hc/en-us/articles/360040772154-In-kind-donations#enter-an-in-kind-donation-0">More info</a>
/// </summary>
[JsonApiName("in_kind_donation")]
public record InKindDonation
{
  /// <summary>
  /// The unique identifier for an in-kind donation.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// The date and time at which an in-kind donation was created.
  /// 
  /// Example: <c>2000-01-01T12:00:00Z</c>
  /// </summary>
  [JsonApiName("created_at")]
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// The date and time at which an in-kind donation was last updated.
  /// 
  /// Example: <c>2000-01-01T12:00:00Z</c>
  /// </summary>
  [JsonApiName("updated_at")]
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// Required. Brief description of an in-kind donation gift.
  /// 
  /// Example: <c>2019 Toyota Corolla (used)</c>
  /// </summary>
  [JsonApiName("description")]
  public string? Description { get; init; }

  /// <summary>
  /// Optional. Records whether any goods or services were exchanged for an in-kind donation.
  /// 
  /// Example: <c>In exchange, a charity event ticket for $100 was provided.</c>
  /// </summary>
  [JsonApiName("exchange_details")]
  public string? ExchangeDetails { get; init; }

  /// <summary>
  /// Optional. The fair market value of an in-kind donation in cents. Must be greater than $0 and less than or equal to $21,000,000.
  /// </summary>
  [JsonApiName("fair_market_value_cents")]
  public int? FairMarketValueCents { get; init; }

  /// <summary>
  /// Required. The date an in-kind donation was received.
  /// 
  /// Format: <c>YYYY-MM-DD</c> (e.g. <c>2025-04-09</c>).
  /// </summary>
  [JsonApiName("received_on")]
  public DateOnly? ReceivedOn { get; init; }

  /// <summary>
  /// Optional. The fair market for an in-kind donation which should be determined by donors and appraisers. Maximum 255 characters. Example: <c>Appraised by Bob Johnson CPA (123 Easy Street, Carlsbad CA 92008)</c>
  /// </summary>
  [JsonApiName("valuation_details")]
  public string? ValuationDetails { get; init; }

  /// <summary>
  /// The timestamp of when the acknowledgment letter was last sent for this in-kind donation. This value is set automatically and cannot be manually changed.
  /// </summary>
  [JsonApiName("acknowledgment_last_sent_at")]
  public DateTime? AcknowledgmentLastSentAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("fair_market_value_currency")]
  public string? FairMarketValueCurrency { get; init; }

}
