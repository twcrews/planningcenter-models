namespace Crews.PlanningCenter.Models.People.V2020_07_22.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.ListShare" />.
/// </summary>
public enum ListShareIncludable
{
  /// <summary>
  /// include associated person
  /// </summary>
  [JsonApiName("person")]
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
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-group) to reverse the order
  /// </summary>
  [JsonApiName("group")]
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
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// Query on a specific group
  /// 
  /// Possible values: <c>No Access</c>, <c>Viewer</c>, <c>Editor</c>, or <c>Manager</c>
  /// </summary>
  [JsonApiName("group")]
  Group,

  /// <summary>
  /// Query on a specific name
  /// </summary>
  [JsonApiName("name")]
  Name,

  /// <summary>
  /// Query on a specific permission
  /// 
  /// Possible values: <c>view</c> or <c>manage</c>
  /// </summary>
  [JsonApiName("permission")]
  Permission,

}

