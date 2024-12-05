namespace Crews.PlanningCenter.Models.Giving.V2018_08_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Donation" />.
/// </summary>
public enum DonationIncludable
{
  /// <summary>
  /// include associated designations
  /// </summary>
  Designations,

  /// <summary>
  /// include associated labels
  /// </summary>
  Labels,

  /// <summary>
  /// include associated note
  /// </summary>
  Note,

  /// <summary>
  /// include associated refund
  /// </summary>
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
  CompletedAt,

  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-received_at) to reverse the order
  /// </summary>
  ReceivedAt,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
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
  CompletedAt,

  /// <summary>
  /// query on a specific created_at
  /// </summary>
  CreatedAt,

  /// <summary>
  /// query on a specific payment_method
  /// </summary>
  PaymentMethod,

  /// <summary>
  /// query on a specific received_at
  /// </summary>
  ReceivedAt,

  /// <summary>
  /// query on a specific updated_at
  /// </summary>
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
  Succeeded,

}

