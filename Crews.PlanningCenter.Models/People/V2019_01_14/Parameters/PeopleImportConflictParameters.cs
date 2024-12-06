namespace Crews.PlanningCenter.Models.People.V2019_01_14.Parameters;

/// <summary>
/// Queryable attributes for <see cref="Entities.PeopleImportConflict" />.
/// </summary>
public enum PeopleImportConflictQueryable
{
  /// <summary>
  /// Query on a specific kind
  /// </summary>
  [JsonApiName("kind")]
  Kind,

  /// <summary>
  /// Query on a specific name
  /// </summary>
  [JsonApiName("name")]
  Name,

}

