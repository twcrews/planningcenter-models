using System.Text.Json;

namespace Crews.PlanningCenter.Models.Giving.V2019_10_18.Entities;

/// <summary>
/// A `Pledge` made by a `Person` toward a particular `PledgeCampaign`.
/// 
/// </summary>
public record Pledge
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// The amount pledged
  /// </summary>
  public int? AmountCents { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? AmountCurrency { get; init; }

  /// <summary>
  /// The amount pledged by the joint giver, if in a joint giving unit
  /// </summary>
  public int? JointGiverAmountCents { get; init; }

  /// <summary>
  /// The amount donated
  /// </summary>
  public int? DonatedTotalCents { get; init; }

  /// <summary>
  /// The amount donated by the joint giver, if in a joint giving unit
  /// </summary>
  public int? JointGiverDonatedTotalCents { get; init; }

}
