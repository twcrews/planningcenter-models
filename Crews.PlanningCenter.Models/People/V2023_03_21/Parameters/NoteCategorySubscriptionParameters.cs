namespace Crews.PlanningCenter.Models.People.V2023_03_21.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.NoteCategorySubscription" />.
/// </summary>
public enum NoteCategorySubscriptionIncludable
{
  /// <summary>
  /// include associated person
  /// </summary>
  Person,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.NoteCategorySubscription" />.
/// </summary>
public enum NoteCategorySubscriptionOrderable
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
/// Queryable attributes for <see cref="Entities.NoteCategorySubscription" />.
/// </summary>
public enum NoteCategorySubscriptionQueryable
{
  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  CreatedAt,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  UpdatedAt,

}

