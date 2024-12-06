namespace Crews.PlanningCenter.Models.People.V2021_08_17.Parameters;

/// <summary>
/// Orderable attributes for <see cref="Entities.FieldOption" />.
/// </summary>
public enum FieldOptionOrderable
{
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
/// Queryable attributes for <see cref="Entities.FieldOption" />.
/// </summary>
public enum FieldOptionQueryable
{
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

