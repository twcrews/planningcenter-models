namespace Crews.PlanningCenter.Models.People.V2022_01_28.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.WorkflowShare" />.
/// </summary>
public enum WorkflowShareIncludable
{
  /// <summary>
  /// include associated person
  /// </summary>
  [JsonApiName("person")]
  Person,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.WorkflowShare" />.
/// </summary>
public enum WorkflowShareQueryable
{
  /// <summary>
  /// Query on a specific permission
  /// 
  /// Possible values: <c>view</c>, <c>manage_cards</c>, or <c>manage</c>
  /// </summary>
  [JsonApiName("permission")]
  Permission,

}

