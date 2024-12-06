namespace Crews.PlanningCenter.Models.People.V2020_07_22.Parameters;

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
  /// Possible values: <c>view</c> or <c>view_create</c>
  /// </summary>
  [JsonApiName("permission")]
  Permission,

}

