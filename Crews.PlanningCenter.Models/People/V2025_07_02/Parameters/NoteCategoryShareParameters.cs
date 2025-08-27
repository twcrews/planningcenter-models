namespace Crews.PlanningCenter.Models.People.V2025_07_02.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.NoteCategoryShare" />.
/// </summary>
public enum NoteCategoryShareIncludable
{
  /// <summary>
  /// include associated person
  /// </summary>
  [JsonApiName("person")]
  Person,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.NoteCategoryShare" />.
/// </summary>
public enum NoteCategoryShareQueryable
{
  /// <summary>
  /// Query on a specific permission
  /// 
  /// Possible values: <c>view</c>, <c>view_create</c>, or <c>manage</c>
  /// </summary>
  [JsonApiName("permission")]
  Permission,

}

