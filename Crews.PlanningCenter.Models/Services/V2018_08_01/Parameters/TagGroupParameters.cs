namespace Crews.PlanningCenter.Models.Services.V2018_08_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.TagGroup" />.
/// </summary>
public enum TagGroupIncludable
{
  /// <summary>
  /// include associated folder
  /// </summary>
  [JsonApiName("folder")]
  Folder,

  /// <summary>
  /// include associated tags
  /// </summary>
  [JsonApiName("tags")]
  Tags,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.TagGroup" />.
/// </summary>
public enum TagGroupQueryable
{
  /// <summary>
  /// Query on a specific name
  /// </summary>
  [JsonApiName("name")]
  Name,

  /// <summary>
  /// Query on a specific tags_for
  /// </summary>
  [JsonApiName("tags_for")]
  TagsFor,

}

/// <summary>
/// Filterable attributes for <see cref="Entities.TagGroup" />.
/// </summary>
public enum TagGroupFilterable
{
  /// <summary>
  /// Filter by arrangement.
  /// </summary>
  [JsonApiName("arrangement")]
  Arrangement,

  /// <summary>
  /// Filter by media.
  /// </summary>
  [JsonApiName("media")]
  Media,

  /// <summary>
  /// Filter by person.
  /// </summary>
  [JsonApiName("person")]
  Person,

  /// <summary>
  /// Filter by song.
  /// </summary>
  [JsonApiName("song")]
  Song,

}

