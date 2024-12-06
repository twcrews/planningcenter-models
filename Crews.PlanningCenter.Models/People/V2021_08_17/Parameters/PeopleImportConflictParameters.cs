namespace Crews.PlanningCenter.Models.People.V2021_08_17.Parameters;

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

