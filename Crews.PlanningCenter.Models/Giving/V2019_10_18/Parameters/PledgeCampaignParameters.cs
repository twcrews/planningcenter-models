namespace Crews.PlanningCenter.Models.Giving.V2019_10_18.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.PledgeCampaign" />.
/// </summary>
public enum PledgeCampaignIncludable
{
  /// <summary>
  /// include associated fund
  /// </summary>
  [JsonApiName("fund")]
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
  [JsonApiName("ends_at")]
  EndsAt,

  /// <summary>
  /// prefix with a hyphen (-starts_at) to reverse the order
  /// </summary>
  [JsonApiName("starts_at")]
  StartsAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.PledgeCampaign" />.
/// </summary>
public enum PledgeCampaignQueryable
{
  /// <summary>
  /// Query on a specific ends_at
  /// </summary>
  [JsonApiName("ends_at")]
  EndsAt,

  /// <summary>
  /// Query on a related fund
  /// </summary>
  [JsonApiName("fund_id")]
  FundId,

  /// <summary>
  /// Query on a specific starts_at
  /// </summary>
  [JsonApiName("starts_at")]
  StartsAt,

}

