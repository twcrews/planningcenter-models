namespace Crews.PlanningCenter.Models.Services.V2018_08_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Item" />.
/// </summary>
public enum ItemIncludable
{
  /// <summary>
  /// include associated arrangement
  /// </summary>
  [JsonApiName("arrangement")]
  Arrangement,

  /// <summary>
  /// include associated item_notes
  /// </summary>
  [JsonApiName("item_notes")]
  ItemNotes,

  /// <summary>
  /// include associated item_times
  /// </summary>
  [JsonApiName("item_times")]
  ItemTimes,

  /// <summary>
  /// include associated key
  /// </summary>
  [JsonApiName("key")]
  Key,

  /// <summary>
  /// include associated media
  /// </summary>
  [JsonApiName("media")]
  Media,

  /// <summary>
  /// include associated selected_attachment
  /// </summary>
  [JsonApiName("selected_attachment")]
  SelectedAttachment,

  /// <summary>
  /// include associated song
  /// </summary>
  [JsonApiName("song")]
  Song,

}

