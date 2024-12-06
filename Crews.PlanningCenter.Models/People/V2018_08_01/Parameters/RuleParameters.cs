namespace Crews.PlanningCenter.Models.People.V2018_08_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Rule" />.
/// </summary>
public enum RuleIncludable
{
  /// <summary>
  /// include associated conditions
  /// </summary>
  [JsonApiName("conditions")]
  Conditions,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.Rule" />.
/// </summary>
public enum RuleOrderable
{
  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-subset) to reverse the order
  /// </summary>
  [JsonApiName("subset")]
  Subset,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Rule" />.
/// </summary>
public enum RuleQueryable
{
  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// Query on a specific subset
  /// </summary>
  [JsonApiName("subset")]
  Subset,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

}

