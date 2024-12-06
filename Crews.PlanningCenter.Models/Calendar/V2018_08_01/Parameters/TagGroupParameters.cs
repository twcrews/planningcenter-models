namespace Crews.PlanningCenter.Models.Calendar.V2018_08_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.TagGroup" />.
/// </summary>
public enum TagGroupIncludable
{
  /// <summary>
  /// include associated events
  /// </summary>
  [JsonApiName("events")]
  Events,

  /// <summary>
  /// include associated tags
  /// </summary>
  [JsonApiName("tags")]
  Tags,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.TagGroup" />.
/// </summary>
public enum TagGroupOrderable
{
  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
  [JsonApiName("name")]
  Name,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.TagGroup" />.
/// </summary>
public enum TagGroupQueryable
{
  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// Query on a specific name
  /// </summary>
  [JsonApiName("name")]
  Name,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

}

/// <summary>
/// Filterable attributes for <see cref="Entities.TagGroup" />.
/// </summary>
public enum TagGroupFilterable
{
  /// <summary>
  /// Filter by required.
  /// </summary>
  [JsonApiName("required")]
  Required,

}

