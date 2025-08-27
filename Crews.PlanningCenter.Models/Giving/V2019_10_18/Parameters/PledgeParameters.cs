namespace Crews.PlanningCenter.Models.Giving.V2019_10_18.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Pledge" />.
/// </summary>
public enum PledgeIncludable
{
  /// <summary>
  /// include associated joint_giver
  /// </summary>
  [JsonApiName("joint_giver")]
  JointGiver,

  /// <summary>
  /// include associated pledge_campaign
  /// </summary>
  [JsonApiName("pledge_campaign")]
  PledgeCampaign,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.Pledge" />.
/// </summary>
public enum PledgeOrderable
{
  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Pledge" />.
/// </summary>
public enum PledgeQueryable
{
  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

}

