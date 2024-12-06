using System.Text.Json;

namespace Crews.PlanningCenter.Models.Giving.V2019_10_18.Entities;

/// <summary>
/// A <c>PledgeCampaign</c> is a way to request and track long-terms commitments to a particular goal or project.
/// </summary>
[JsonApiName("pledge_campaign")]
public record PledgeCampaign
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
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("name")]
  public string? Name { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("description")]
  public string? Description { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("starts_at")]
  public DateTime? StartsAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("ends_at")]
  public DateTime? EndsAt { get; init; }

  /// <summary>
  /// Optional. During the donation period of this campaign, the running total of donations will be tracked against this number
  /// </summary>
  [JsonApiName("goal_cents")]
  public int? GoalCents { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("goal_currency")]
  public string? GoalCurrency { get; init; }

  /// <summary>
  /// In addition to seeing their personal pledge progress within their donor profile, this option allows donors to see the the collective progress towards the campaign’s overall goal (if set).
  /// </summary>
  [JsonApiName("show_goal_in_church_center")]
  public bool? ShowGoalInChurchCenter { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("received_total_from_pledges_cents")]
  public int? ReceivedTotalFromPledgesCents { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("received_total_outside_of_pledges_cents")]
  public int? ReceivedTotalOutsideOfPledgesCents { get; init; }

}
