namespace Crews.PlanningCenter.Models.Services.V2018_08_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Item" />.
/// </summary>
public enum ItemIncludable
{
  /// <summary>
  /// include associated arrangement
  /// </summary>
  Arrangement,

  /// <summary>
  /// include associated item_notes
  /// </summary>
  ItemNotes,

  /// <summary>
  /// include associated item_times
  /// </summary>
  ItemTimes,

  /// <summary>
  /// include associated key
  /// </summary>
  Key,

  /// <summary>
  /// include associated media
  /// </summary>
  Media,

  /// <summary>
  /// include associated selected_attachment
  /// </summary>
  SelectedAttachment,

  /// <summary>
  /// include associated song
  /// </summary>
  Song,

}

