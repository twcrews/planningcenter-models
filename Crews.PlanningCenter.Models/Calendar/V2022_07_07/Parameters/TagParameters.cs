namespace Crews.PlanningCenter.Models.Calendar.V2022_07_07.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Tag" />.
/// </summary>
public enum TagIncludable
{
  /// <summary>
  /// include associated tag_group
  /// </summary>
  [JsonApiName("tag_group")]
  TagGroup,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.Tag" />.
/// </summary>
public enum TagOrderable
{
  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
  [JsonApiName("name")]
  Name,

  /// <summary>
  /// prefix with a hyphen (-position) to reverse the order
  /// </summary>
  [JsonApiName("position")]
  Position,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Tag" />.
/// </summary>
public enum TagQueryable
{
  /// <summary>
  /// Query on a specific church_center_category
  /// </summary>
  [JsonApiName("church_center_category")]
  ChurchCenterCategory,

  /// <summary>
  /// Query on a specific color
  /// </summary>
  [JsonApiName("color")]
  Color,

  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// Query on a specific id
  /// </summary>
  [JsonApiName("id")]
  Id,

  /// <summary>
  /// Query on a specific name
  /// </summary>
  [JsonApiName("name")]
  Name,

  /// <summary>
  /// Query on a specific position
  /// </summary>
  [JsonApiName("position")]
  Position,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

}

/// <summary>
/// Filterable attributes for <see cref="Entities.Tag" />.
/// </summary>
public enum TagFilterable
{
  /// <summary>
  /// Filter by individual.
  /// </summary>
  [JsonApiName("individual")]
  Individual,

}

