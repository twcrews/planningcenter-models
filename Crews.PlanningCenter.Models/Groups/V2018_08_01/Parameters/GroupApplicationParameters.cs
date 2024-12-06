namespace Crews.PlanningCenter.Models.Groups.V2018_08_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.GroupApplication" />.
/// </summary>
public enum GroupApplicationIncludable
{
  /// <summary>
  /// include associated group
  /// </summary>
  [JsonApiName("group")]
  Group,

  /// <summary>
  /// include associated person
  /// </summary>
  [JsonApiName("person")]
  Person,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.GroupApplication" />.
/// </summary>
public enum GroupApplicationOrderable
{
  /// <summary>
  /// prefix with a hyphen (-applied_at) to reverse the order
  /// </summary>
  [JsonApiName("applied_at")]
  AppliedAt,

  /// <summary>
  /// prefix with a hyphen (-status) to reverse the order
  /// </summary>
  [JsonApiName("status")]
  Status,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.GroupApplication" />.
/// </summary>
public enum GroupApplicationQueryable
{
  /// <summary>
  /// Query on a specific applied_at
  /// </summary>
  [JsonApiName("applied_at")]
  AppliedAt,

  /// <summary>
  /// Query on a specific status
  /// </summary>
  [JsonApiName("status")]
  Status,

}

