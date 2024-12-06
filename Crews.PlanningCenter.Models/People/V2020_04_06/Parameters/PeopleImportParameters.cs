namespace Crews.PlanningCenter.Models.People.V2020_04_06.Parameters;

/// <summary>
/// Queryable attributes for <see cref="Entities.PeopleImport" />.
/// </summary>
public enum PeopleImportQueryable
{
  /// <summary>
  /// Query on a specific status
  /// 
  /// Possible values: <c>matching</c>, <c>processing_preview</c>, <c>previewing</c>, <c>processing_import</c>, <c>complete</c>, <c>undone</c>, or <c>undoing</c>
  /// </summary>
  [JsonApiName("status")]
  Status,

}

