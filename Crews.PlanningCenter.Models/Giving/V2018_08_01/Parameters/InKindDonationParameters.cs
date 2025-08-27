namespace Crews.PlanningCenter.Models.Giving.V2018_08_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.InKindDonation" />.
/// </summary>
public enum InKindDonationIncludable
{
  /// <summary>
  /// include associated campus
  /// </summary>
  [JsonApiName("campus")]
  Campus,

  /// <summary>
  /// include associated fund
  /// </summary>
  [JsonApiName("fund")]
  Fund,

  /// <summary>
  /// include associated person
  /// </summary>
  [JsonApiName("person")]
  Person,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.InKindDonation" />.
/// </summary>
public enum InKindDonationOrderable
{
  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-received_on) to reverse the order
  /// </summary>
  [JsonApiName("received_on")]
  ReceivedOn,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.InKindDonation" />.
/// </summary>
public enum InKindDonationQueryable
{
  /// <summary>
  /// <c>Campus</c> is automatically assigned based on the donor's primary campus. If you pass an explicit value (a relationship reference or <c>null</c>), it will override the default.
  /// </summary>
  [JsonApiName("campus_id")]
  CampusId,

  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// <c>Fund</c> is required.
  /// </summary>
  [JsonApiName("fund_id")]
  FundId,

  /// <summary>
  /// Query on a specific received_on
  /// </summary>
  [JsonApiName("received_on")]
  ReceivedOn,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

}

