namespace Crews.PlanningCenter.Models.Services.V2018_08_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.PlanNote" />.
/// </summary>
public enum PlanNoteIncludable
{
  /// <summary>
  /// include associated plan_note_category
  /// </summary>
  [JsonApiName("plan_note_category")]
  PlanNoteCategory,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.PlanNote" />.
/// </summary>
public enum PlanNoteOrderable
{
  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.PlanNote" />.
/// </summary>
public enum PlanNoteQueryable
{
  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

}

