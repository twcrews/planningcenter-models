namespace Crews.PlanningCenter.Models.Calendar.V2018_08_01.Parameters;

/// <summary>
/// Orderable attributes for <see cref="Entities.Feed" />.
/// </summary>
public enum FeedOrderable
{
  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
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
  FeedType,

  /// <summary>
  /// Query on a specific source_id
  /// </summary>
  SourceId,

}

