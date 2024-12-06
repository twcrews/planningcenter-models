namespace Crews.PlanningCenter.Models.Groups.V2018_08_01.Parameters;

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

  /// <summary>
  /// prefix with a hyphen (-position) to reverse the order
  /// </summary>
  [JsonApiName("position")]
  Position,

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

}

/// <summary>
/// Filterable attributes for <see cref="Entities.TagGroup" />.
/// </summary>
public enum TagGroupFilterable
{
  /// <summary>
  /// Filter by public.
  /// </summary>
  [JsonApiName("public")]
  Public,

}

