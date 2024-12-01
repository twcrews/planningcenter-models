using System.Text.Json;

namespace Crews.PlanningCenter.Models.Services.V2018_08_01.Entities;

/// <summary>
/// An item in a plan.
/// </summary>
public record Item
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Title { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public int? Sequence { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public int? Length { get; init; }

  /// <summary>
  /// There are 4 possible values:
  /// 
  /// - `song`: The item is a song
  /// 
  /// - `header`: The item is a header
  /// 
  /// - `media`: The item is a piece of media
  /// 
  /// - `item`: The default item type
  /// 
  /// This value can only be set when an item is created. The only value that you can pass is `header`. If no value is passed then `item` will be used. To create a media item you'll attach a video media to the item, and to create a song item, you'll attach a song.
  /// 
  /// </summary>
  public string? ItemType { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? HtmlDetails { get; init; }

  /// <summary>
  /// There are 3 possible values:
  /// 
  /// - `pre`: the item happens before the service starts
  /// 
  /// - `post`: the item happens after the service ends
  /// 
  /// - `during`: the item happens during the service
  /// 
  /// </summary>
  public string? ServicePosition { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Description { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? KeyName { get; init; }

  /// <summary>
  /// An array of strings containing a label and a number describing the section:
  /// 
  /// ['Verse 1', 'Chorus 1', 'Verse 2']
  /// 
  /// </summary>
  public IEnumerable<JsonElement>? CustomArrangementSequence { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public IEnumerable<JsonElement>? CustomArrangementSequenceShort { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public IEnumerable<JsonElement>? CustomArrangementSequenceFull { get; init; }

}
