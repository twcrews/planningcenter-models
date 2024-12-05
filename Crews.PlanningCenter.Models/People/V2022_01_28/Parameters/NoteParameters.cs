namespace Crews.PlanningCenter.Models.People.V2022_01_28.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Note" />.
/// </summary>
public enum NoteIncludable
{
  /// <summary>
  /// include associated category
  /// </summary>
  Category,

  /// <summary>
  /// include associated created_by
  /// </summary>
  CreatedBy,

  /// <summary>
  /// include associated person
  /// </summary>
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
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-display_date) to reverse the order
  /// </summary>
  DisplayDate,

  /// <summary>
  /// prefix with a hyphen (-id) to reverse the order
  /// </summary>
  Id,

  /// <summary>
  /// prefix with a hyphen (-note) to reverse the order
  /// </summary>
  Note,

  /// <summary>
  /// prefix with a hyphen (-note_category_id) to reverse the order
  /// </summary>
  NoteCategoryId,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
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
  Note,

  /// <summary>
  /// Query on a specific note_category_id
  /// </summary>
  NoteCategoryId,

}

