using System.Text.Json;

namespace Crews.PlanningCenter.Models.Giving.V2019_10_18.Entities;

/// <summary>
/// A donation's `PaymentSource` refers to the platform it originated from.
/// 
/// `Donation`s made through Giving will be assigned the built-in `PaymentSource` "Planning Center". `Donation`s made through external platforms (Square, Pushpay, ect.) can be assigned a `PaymentSource` identifying them as such.
/// 
/// </summary>
public record PaymentSource
{
  /// <summary>
  /// The unique identifier for a payment source.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// The date and time at which a payment source was created. Example: `2000-01-01T12:00:00Z`
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// The date and time at which a payment source was last updated. Example: `2000-01-01T12:00:00Z`
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// Required. The name of a payment source. Must be unique within the associated organization.
  /// </summary>
  public string? Name { get; init; }

  /// <summary>
  /// For more info on payment source types, please refer to our [documentation on creating a payment source](https://pcogiving.zendesk.com/hc/en-us/articles/115012277207-Payment-Sources#create-the-payment-source-1).
  /// 
  /// 
  /// 
  /// Possible values: `direct_from_donor`, `donor_advised_fund`, or `qualified_charitable_distribution`
  /// </summary>
  public string? PaymentSourceType { get; init; }

}
