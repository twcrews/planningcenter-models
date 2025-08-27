namespace Crews.PlanningCenter.Models.People.V2025_03_20.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.BackgroundCheck" />.
/// </summary>
public enum BackgroundCheckIncludable
{
  /// <summary>
  /// include associated person
  /// </summary>
  [JsonApiName("person")]
  Person,

}

/// <summary>
/// Filterable attributes for <see cref="Entities.BackgroundCheck" />.
/// </summary>
public enum BackgroundCheckFilterable
{
  /// <summary>
  /// Filter by current.
  /// </summary>
  [JsonApiName("current")]
  Current,

}

