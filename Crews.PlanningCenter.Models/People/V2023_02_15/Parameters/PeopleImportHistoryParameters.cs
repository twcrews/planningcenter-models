namespace Crews.PlanningCenter.Models.People.V2023_02_15.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.PeopleImportHistory" />.
/// </summary>
public enum PeopleImportHistoryIncludable
{
  /// <summary>
  /// include associated household
  /// </summary>
  [JsonApiName("household")]
  Household,

  /// <summary>
  /// include associated person
  /// </summary>
  [JsonApiName("person")]
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
  [JsonApiName("name")]
  Name,

}

