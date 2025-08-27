namespace Crews.PlanningCenter.Models.People.V2025_07_17.Parameters;

/// <summary>
/// Orderable attributes for <see cref="Entities.PersonMerger" />.
/// </summary>
public enum PersonMergerOrderable
{
  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  [JsonApiName("created_at")]
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
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// Query on a specific person_to_keep_id
  /// </summary>
  [JsonApiName("person_to_keep_id")]
  PersonToKeepId,

  /// <summary>
  /// Query on a specific person_to_remove_id
  /// </summary>
  [JsonApiName("person_to_remove_id")]
  PersonToRemoveId,

}

