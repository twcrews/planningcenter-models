namespace Crews.PlanningCenter.Models.Services.V2018_08_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.TagGroup" />.
/// </summary>
public enum TagGroupIncludable
{
  /// <summary>
  /// include associated folder
  /// </summary>
  Folder,

  /// <summary>
  /// include associated tags
  /// </summary>
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
  Name,

  /// <summary>
  /// Query on a specific tags_for
  /// </summary>
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
  Arrangement,

  /// <summary>
  /// Filter by media.
  /// </summary>
  Media,

  /// <summary>
  /// Filter by person.
  /// </summary>
  Person,

  /// <summary>
  /// Filter by song.
  /// </summary>
  Song,

}

