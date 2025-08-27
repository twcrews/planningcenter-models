namespace Crews.PlanningCenter.Models.People.V2025_03_20.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Note" />.
/// </summary>
public enum NoteIncludable
{
  /// <summary>
  /// include associated category
  /// </summary>
  [JsonApiName("category")]
  Category,

  /// <summary>
  /// include associated created_by
  /// </summary>
  [JsonApiName("created_by")]
  CreatedBy,

  /// <summary>
  /// include associated person
  /// </summary>
  [JsonApiName("person")]
  Person,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.Note" />.
/// </summary>
public enum NoteOrderable
{
  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-display_date) to reverse the order
  /// </summary>
  [JsonApiName("display_date")]
  DisplayDate,

  /// <summary>
  /// prefix with a hyphen (-id) to reverse the order
  /// </summary>
  [JsonApiName("id")]
  Id,

  /// <summary>
  /// prefix with a hyphen (-note) to reverse the order
  /// </summary>
  [JsonApiName("note")]
  Note,

  /// <summary>
  /// prefix with a hyphen (-note_category_id) to reverse the order
  /// </summary>
  [JsonApiName("note_category_id")]
  NoteCategoryId,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Note" />.
/// </summary>
public enum NoteQueryable
{
  /// <summary>
  /// Query on a specific note
  /// </summary>
  [JsonApiName("note")]
  Note,

  /// <summary>
  /// Query on a specific note_category_id
  /// </summary>
  [JsonApiName("note_category_id")]
  NoteCategoryId,

}

