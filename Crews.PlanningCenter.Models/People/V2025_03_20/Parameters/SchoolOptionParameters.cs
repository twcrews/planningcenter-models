namespace Crews.PlanningCenter.Models.People.V2025_03_20.Parameters;

/// <summary>
/// Orderable attributes for <see cref="Entities.SchoolOption" />.
/// </summary>
public enum SchoolOptionOrderable
{
  /// <summary>
  /// prefix with a hyphen (-beginning_grade) to reverse the order
  /// </summary>
  [JsonApiName("beginning_grade")]
  BeginningGrade,

  /// <summary>
  /// prefix with a hyphen (-ending_grade) to reverse the order
  /// </summary>
  [JsonApiName("ending_grade")]
  EndingGrade,

  /// <summary>
  /// prefix with a hyphen (-sequence) to reverse the order
  /// </summary>
  [JsonApiName("sequence")]
  Sequence,

  /// <summary>
  /// prefix with a hyphen (-value) to reverse the order
  /// </summary>
  [JsonApiName("value")]
  Value,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.SchoolOption" />.
/// </summary>
public enum SchoolOptionQueryable
{
  /// <summary>
  /// Query on a specific beginning_grade
  /// </summary>
  [JsonApiName("beginning_grade")]
  BeginningGrade,

  /// <summary>
  /// Query on a specific ending_grade
  /// </summary>
  [JsonApiName("ending_grade")]
  EndingGrade,

  /// <summary>
  /// Query on a specific school_types
  /// </summary>
  [JsonApiName("school_types")]
  SchoolTypes,

  /// <summary>
  /// Query on a specific sequence
  /// </summary>
  [JsonApiName("sequence")]
  Sequence,

  /// <summary>
  /// Query on a specific value
  /// </summary>
  [JsonApiName("value")]
  Value,

}

