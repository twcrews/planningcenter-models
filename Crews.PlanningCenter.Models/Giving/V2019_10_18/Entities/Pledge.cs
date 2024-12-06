using System.Text.Json;

namespace Crews.PlanningCenter.Models.Giving.V2019_10_18.Entities;

/// <summary>
/// A <c>Pledge</c> made by a <c>Person</c> toward a particular <c>PledgeCampaign</c>.
/// </summary>
[JsonApiName("pledge")]
public record Pledge
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("created_at")]
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("updated_at")]
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// The amount pledged
  /// </summary>
  [JsonApiName("amount_cents")]
  public int? AmountCents { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("amount_currency")]
  public string? AmountCurrency { get; init; }

  /// <summary>
  /// The amount pledged by the joint giver, if in a joint giving unit
  /// </summary>
  [JsonApiName("joint_giver_amount_cents")]
  public int? JointGiverAmountCents { get; init; }

  /// <summary>
  /// The amount donated
  /// </summary>
  [JsonApiName("donated_total_cents")]
  public int? DonatedTotalCents { get; init; }

  /// <summary>
  /// The amount donated by the joint giver, if in a joint giving unit
  /// </summary>
  [JsonApiName("joint_giver_donated_total_cents")]
  public int? JointGiverDonatedTotalCents { get; init; }

}
