using System.Text.Json;

namespace Crews.PlanningCenter.Models.Giving.V2018_08_01.Entities;

/// <summary>
/// A donation's <c>PaymentSource</c> refers to the platform it originated from.
/// 
/// <c>Donation</c>s made through Giving will be assigned the built-in <c>PaymentSource</c> "Planning Center". <c>Donation</c>s made through external platforms (Square, Pushpay, ect.) can be assigned a <c>PaymentSource</c> identifying them as such.
/// </summary>
[JsonApiName("payment_source")]
public record PaymentSource
{
  /// <summary>
  /// The unique identifier for a payment source.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// The date and time at which a payment source was created. Example: <c>2000-01-01T12:00:00Z</c>
  /// </summary>
  [JsonApiName("created_at")]
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// The date and time at which a payment source was last updated. Example: <c>2000-01-01T12:00:00Z</c>
  /// </summary>
  [JsonApiName("updated_at")]
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// Required. The name of a payment source. Must be unique within the associated organization.
  /// </summary>
  [JsonApiName("name")]
  public string? Name { get; init; }

  /// <summary>
  /// For more info on payment source types, please refer to our <a href="https://pcogiving.zendesk.com/hc/en-us/articles/115012277207-Payment-Sources#create-the-payment-source-1">documentation on creating a payment source</a>.
  /// 
  /// Possible values: <c>direct_from_donor</c>, <c>donor_advised_fund</c>, or <c>qualified_charitable_distribution</c>
  /// </summary>
  [JsonApiName("payment_source_type")]
  public string? PaymentSourceType { get; init; }

}
