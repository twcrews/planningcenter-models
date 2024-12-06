namespace Crews.PlanningCenter.Models.Calendar.V2018_08_01.Parameters;

/// <summary>
/// Orderable attributes for <see cref="Entities.Feed" />.
/// </summary>
public enum FeedOrderable
{
  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
  [JsonApiName("name")]
  Name,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Feed" />.
/// </summary>
public enum FeedQueryable
{
  /// <summary>
  /// Query on a specific feed_type
  /// 
  /// Possible values: <c>registrations</c>, <c>groups</c>, <c>ical</c>, or <c>form</c>
  /// </summary>
  [JsonApiName("feed_type")]
  FeedType,

  /// <summary>
  /// Query on a specific source_id
  /// </summary>
  [JsonApiName("source_id")]
  SourceId,

}

