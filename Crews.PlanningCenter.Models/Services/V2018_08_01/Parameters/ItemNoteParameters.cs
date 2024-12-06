namespace Crews.PlanningCenter.Models.Services.V2018_08_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.ItemNote" />.
/// </summary>
public enum ItemNoteIncludable
{
  /// <summary>
  /// include associated item_note_category
  /// </summary>
  [JsonApiName("item_note_category")]
  ItemNoteCategory,

}

