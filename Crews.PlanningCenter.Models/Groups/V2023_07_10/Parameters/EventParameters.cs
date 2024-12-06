namespace Crews.PlanningCenter.Models.Groups.V2023_07_10.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Event" />.
/// </summary>
public enum EventIncludable
{
  /// <summary>
  /// include associated group
  /// </summary>
  [JsonApiName("group")]
  Group,

  /// <summary>
  /// include associated location
  /// </summary>
  [JsonApiName("location")]
  Location,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.Event" />.
/// </summary>
public enum EventOrderable
{
  /// <summary>
  /// prefix with a hyphen (-ends_at) to reverse the order
  /// </summary>
  [JsonApiName("ends_at")]
  EndsAt,

  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
  [JsonApiName("name")]
  Name,

  /// <summary>
  /// prefix with a hyphen (-starts_at) to reverse the order
  /// </summary>
  [JsonApiName("starts_at")]
  StartsAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Event" />.
/// </summary>
public enum EventQueryable
{
  /// <summary>
  /// Query on a specific ends_at
  /// </summary>
  [JsonApiName("ends_at")]
  EndsAt,

  /// <summary>
  /// Query on a specific name
  /// </summary>
  [JsonApiName("name")]
  Name,

  /// <summary>
  /// Query on a specific starts_at
  /// </summary>
  [JsonApiName("starts_at")]
  StartsAt,

}

/// <summary>
/// Filterable attributes for <see cref="Entities.Event" />.
/// </summary>
public enum EventFilterable
{
  /// <summary>
  /// Filter by canceled.
  /// </summary>
  [JsonApiName("canceled")]
  Canceled,

  /// <summary>
  /// Filter by group.
  /// </summary>
  [JsonApiName("group")]
  Group,

  /// <summary>
  /// Filter by group_type.
  /// </summary>
  [JsonApiName("group_type")]
  GroupType,

  /// <summary>
  /// Filter by my_groups.
  /// </summary>
  [JsonApiName("my_groups")]
  MyGroups,

  /// <summary>
  /// Filter by not_canceled.
  /// </summary>
  [JsonApiName("not_canceled")]
  NotCanceled,

  /// <summary>
  /// Filter by upcoming.
  /// </summary>
  [JsonApiName("upcoming")]
  Upcoming,

}

