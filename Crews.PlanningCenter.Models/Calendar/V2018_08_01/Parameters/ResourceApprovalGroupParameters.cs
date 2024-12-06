namespace Crews.PlanningCenter.Models.Calendar.V2018_08_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.ResourceApprovalGroup" />.
/// </summary>
public enum ResourceApprovalGroupIncludable
{
  /// <summary>
  /// include associated people
  /// </summary>
  [JsonApiName("people")]
  People,

  /// <summary>
  /// include associated resources
  /// </summary>
  [JsonApiName("resources")]
  Resources,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.ResourceApprovalGroup" />.
/// </summary>
public enum ResourceApprovalGroupOrderable
{
  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
  [JsonApiName("name")]
  Name,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.ResourceApprovalGroup" />.
/// </summary>
public enum ResourceApprovalGroupQueryable
{
  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// Query on a specific name
  /// </summary>
  [JsonApiName("name")]
  Name,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

}

