using System.Text.Json;

namespace Crews.PlanningCenter.Models.Services.V2018_08_01.Entities;

/// <summary>
/// An item in a plan.
/// </summary>
[JsonApiName("item")]
public record Item
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("title")]
  public string? Title { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("sequence")]
  public int? Sequence { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("created_at")]
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("updated_at")]
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("length")]
  public int? Length { get; init; }

  /// <summary>
  /// There are 4 possible values:
  /// 
  /// - <c>song</c>: The item is a song
  /// 
  /// - <c>header</c>: The item is a header
  /// 
  /// - <c>media</c>: The item is a piece of media
  /// 
  /// - <c>item</c>: The default item type
  /// 
  /// This value can only be set when an item is created. The only value that you can pass is <c>header</c>. If no value is passed then <c>item</c> will be used. To create a media item you'll attach a video media to the item, and to create a song item, you'll attach a song.
  /// </summary>
  [JsonApiName("item_type")]
  public string? ItemType { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("html_details")]
  public string? HtmlDetails { get; init; }

  /// <summary>
  /// There are 3 possible values:
  /// 
  /// - <c>pre</c>: the item happens before the service starts
  /// 
  /// - <c>post</c>: the item happens after the service ends
  /// 
  /// - <c>during</c>: the item happens during the service
  /// </summary>
  [JsonApiName("service_position")]
  public string? ServicePosition { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("description")]
  public string? Description { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("key_name")]
  public string? KeyName { get; init; }

  /// <summary>
  /// An array of strings containing a label and a number describing the section:
  /// 
  /// ['Verse 1', 'Chorus 1', 'Verse 2']
  /// </summary>
  [JsonApiName("custom_arrangement_sequence")]
  public IEnumerable<JsonElement>? CustomArrangementSequence { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("custom_arrangement_sequence_short")]
  public IEnumerable<JsonElement>? CustomArrangementSequenceShort { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("custom_arrangement_sequence_full")]
  public IEnumerable<JsonElement>? CustomArrangementSequenceFull { get; init; }

}
