namespace Crews.PlanningCenter.Models.People.V2020_04_06.Parameters;

/// <summary>
/// Orderable attributes for <see cref="Entities.SchoolOption" />.
/// </summary>
public enum SchoolOptionOrderable
{
  /// <summary>
  /// prefix with a hyphen (-beginning_grade) to reverse the order
  /// </summary>
  BeginningGrade,

  /// <summary>
  /// prefix with a hyphen (-ending_grade) to reverse the order
  /// </summary>
  EndingGrade,

  /// <summary>
  /// prefix with a hyphen (-sequence) to reverse the order
  /// </summary>
  Sequence,

  /// <summary>
  /// prefix with a hyphen (-value) to reverse the order
  /// </summary>
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
  BeginningGrade,

  /// <summary>
  /// Query on a specific ending_grade
  /// </summary>
  EndingGrade,

  /// <summary>
  /// Query on a specific school_types
  /// </summary>
  SchoolTypes,

  /// <summary>
  /// Query on a specific sequence
  /// </summary>
  Sequence,

  /// <summary>
  /// Query on a specific value
  /// </summary>
  Value,

}

