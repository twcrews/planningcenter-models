namespace Crews.PlanningCenter.Models.Calendar.V2021_07_20.Parameters;

/// <summary>
/// Queryable attributes for <see cref="Entities.ResourceQuestion" />.
/// </summary>
public enum ResourceQuestionQueryable
{
  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// Query on a specific kind
  /// </summary>
  [JsonApiName("kind")]
  Kind,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

}

