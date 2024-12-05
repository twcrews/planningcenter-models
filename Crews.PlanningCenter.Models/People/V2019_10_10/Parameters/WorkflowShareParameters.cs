namespace Crews.PlanningCenter.Models.People.V2019_10_10.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.WorkflowShare" />.
/// </summary>
public enum WorkflowShareIncludable
{
  /// <summary>
  /// include associated person
  /// </summary>
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
  Permission,

}

