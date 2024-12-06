namespace Crews.PlanningCenter.Models.Giving.V2019_10_18.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Donation" />.
/// </summary>
public enum DonationIncludable
{
  /// <summary>
  /// include associated designations
  /// </summary>
  [JsonApiName("designations")]
  Designations,

  /// <summary>
  /// include associated labels
  /// </summary>
  [JsonApiName("labels")]
  Labels,

  /// <summary>
  /// include associated note
  /// </summary>
  [JsonApiName("note")]
  Note,

  /// <summary>
  /// include associated refund
  /// </summary>
  [JsonApiName("refund")]
  Refund,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.Donation" />.
/// </summary>
public enum DonationOrderable
{
  /// <summary>
  /// prefix with a hyphen (-completed_at) to reverse the order
  /// </summary>
  [JsonApiName("completed_at")]
  CompletedAt,

  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-received_at) to reverse the order
  /// </summary>
  [JsonApiName("received_at")]
  ReceivedAt,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Donation" />.
/// </summary>
public enum DonationQueryable
{
  /// <summary>
  /// query on a specific completed_at
  /// </summary>
  [JsonApiName("completed_at")]
  CompletedAt,

  /// <summary>
  /// query on a specific created_at
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// query on a specific payment_method
  /// </summary>
  [JsonApiName("payment_method")]
  PaymentMethod,

  /// <summary>
  /// query on a specific received_at
  /// </summary>
  [JsonApiName("received_at")]
  ReceivedAt,

  /// <summary>
  /// query on a specific updated_at
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

}

/// <summary>
/// Filterable attributes for <see cref="Entities.Donation" />.
/// </summary>
public enum DonationFilterable
{
  /// <summary>
  /// Filter by succeeded.
  /// </summary>
  [JsonApiName("succeeded")]
  Succeeded,

}

