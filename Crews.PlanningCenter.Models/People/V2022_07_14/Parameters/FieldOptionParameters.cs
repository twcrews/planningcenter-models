namespace Crews.PlanningCenter.Models.People.V2022_07_14.Parameters;

/// <summary>
/// Orderable attributes for <see cref="Entities.FieldOption" />.
/// </summary>
public enum FieldOptionOrderable
{
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
/// Queryable attributes for <see cref="Entities.FieldOption" />.
/// </summary>
public enum FieldOptionQueryable
{
  /// <summary>
  /// Query on a specific sequence
  /// </summary>
  Sequence,

  /// <summary>
  /// Query on a specific value
  /// </summary>
  Value,

}

