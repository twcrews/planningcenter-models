namespace Crews.PlanningCenter.Models.Services.V2018_11_01.Parameters;

/// <summary>
/// Orderable attributes for <see cref="Entities.PlanTemplate" />.
/// </summary>
public enum PlanTemplateOrderable
{
  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-item_count) to reverse the order
  /// </summary>
  [JsonApiName("item_count")]
  ItemCount,

  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
  [JsonApiName("name")]
  Name,

  /// <summary>
  /// prefix with a hyphen (-note_count) to reverse the order
  /// </summary>
  [JsonApiName("note_count")]
  NoteCount,

  /// <summary>
  /// prefix with a hyphen (-team_count) to reverse the order
  /// </summary>
  [JsonApiName("team_count")]
  TeamCount,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

}

