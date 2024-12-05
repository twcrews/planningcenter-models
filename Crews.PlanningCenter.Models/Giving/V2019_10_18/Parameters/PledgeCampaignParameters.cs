namespace Crews.PlanningCenter.Models.Giving.V2019_10_18.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.PledgeCampaign" />.
/// </summary>
public enum PledgeCampaignIncludable
{
  /// <summary>
  /// include associated fund
  /// </summary>
  Fund,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.PledgeCampaign" />.
/// </summary>
public enum PledgeCampaignOrderable
{
  /// <summary>
  /// prefix with a hyphen (-ends_at) to reverse the order
  /// </summary>
  EndsAt,

  /// <summary>
  /// prefix with a hyphen (-starts_at) to reverse the order
  /// </summary>
  StartsAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.PledgeCampaign" />.
/// </summary>
public enum PledgeCampaignQueryable
{
  /// <summary>
  /// query on a specific ends_at
  /// </summary>
  EndsAt,

  /// <summary>
  /// query on a specific starts_at
  /// </summary>
  StartsAt,

}

