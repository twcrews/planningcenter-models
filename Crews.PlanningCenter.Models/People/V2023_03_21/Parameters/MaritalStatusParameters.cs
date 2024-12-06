namespace Crews.PlanningCenter.Models.People.V2023_03_21.Parameters;

/// <summary>
/// Orderable attributes for <see cref="Entities.MaritalStatus" />.
/// </summary>
public enum MaritalStatusOrderable
{
  /// <summary>
  /// prefix with a hyphen (-value) to reverse the order
  /// </summary>
  [JsonApiName("value")]
  Value,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.MaritalStatus" />.
/// </summary>
public enum MaritalStatusQueryable
{
  /// <summary>
  /// Query on a specific value
  /// </summary>
  [JsonApiName("value")]
  Value,

}

