namespace Crews.PlanningCenter.Models.People.V2019_01_14.Parameters;

/// <summary>
/// Orderable attributes for <see cref="Entities.InactiveReason" />.
/// </summary>
public enum InactiveReasonOrderable
{
  /// <summary>
  /// prefix with a hyphen (-value) to reverse the order
  /// </summary>
  [JsonApiName("value")]
  Value,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.InactiveReason" />.
/// </summary>
public enum InactiveReasonQueryable
{
  /// <summary>
  /// Query on a specific value
  /// </summary>
  [JsonApiName("value")]
  Value,

}

