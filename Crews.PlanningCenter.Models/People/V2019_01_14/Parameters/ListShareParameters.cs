namespace Crews.PlanningCenter.Models.People.V2019_01_14.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.ListShare" />.
/// </summary>
public enum ListShareIncludable
{
  /// <summary>
  /// include associated person
  /// </summary>
  Person,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.ListShare" />.
/// </summary>
public enum ListShareOrderable
{
  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-group) to reverse the order
  /// </summary>
  Group,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.ListShare" />.
/// </summary>
public enum ListShareQueryable
{
  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  CreatedAt,

  /// <summary>
  /// Query on a specific group
  /// 
  /// Possible values: <c>No Access</c>, <c>Viewer</c>, <c>Editor</c>, or <c>Manager</c>
  /// </summary>
  Group,

  /// <summary>
  /// Query on a specific name
  /// </summary>
  Name,

  /// <summary>
  /// Query on a specific permission
  /// 
  /// Possible values: <c>view</c> or <c>manage</c>
  /// </summary>
  Permission,

}

