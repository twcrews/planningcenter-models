namespace Crews.PlanningCenter.Models.Giving.V2019_10_18.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Pledge" />.
/// </summary>
public enum PledgeIncludable
{
  /// <summary>
  /// include associated joint_giver
  /// </summary>
  JointGiver,

  /// <summary>
  /// include associated pledge_campaign
  /// </summary>
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
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  UpdatedAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Pledge" />.
/// </summary>
public enum PledgeQueryable
{
  /// <summary>
  /// query on a specific created_at
  /// </summary>
  CreatedAt,

  /// <summary>
  /// query on a specific updated_at
  /// </summary>
  UpdatedAt,

}

