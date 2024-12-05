namespace Crews.PlanningCenter.Models.People.V2021_08_17.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.PeopleImportHistory" />.
/// </summary>
public enum PeopleImportHistoryIncludable
{
  /// <summary>
  /// include associated household
  /// </summary>
  Household,

  /// <summary>
  /// include associated person
  /// </summary>
  Person,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.PeopleImportHistory" />.
/// </summary>
public enum PeopleImportHistoryQueryable
{
  /// <summary>
  /// Query on a specific name
  /// </summary>
  Name,

}

