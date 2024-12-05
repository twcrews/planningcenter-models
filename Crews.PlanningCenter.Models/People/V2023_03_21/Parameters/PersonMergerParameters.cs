namespace Crews.PlanningCenter.Models.People.V2023_03_21.Parameters;

/// <summary>
/// Orderable attributes for <see cref="Entities.PersonMerger" />.
/// </summary>
public enum PersonMergerOrderable
{
  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  CreatedAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.PersonMerger" />.
/// </summary>
public enum PersonMergerQueryable
{
  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  CreatedAt,

  /// <summary>
  /// Query on a specific person_to_keep_id
  /// </summary>
  PersonToKeepId,

  /// <summary>
  /// Query on a specific person_to_remove_id
  /// </summary>
  PersonToRemoveId,

}

