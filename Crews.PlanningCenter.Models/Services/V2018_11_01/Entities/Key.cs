using System.Text.Json;

namespace Crews.PlanningCenter.Models.Services.V2018_11_01.Entities;

/// <summary>
/// Each song arrangement can have multiple keys. A key is the pitch center of the song.
/// </summary>
[JsonApiName("key")]
public record Key
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

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
  [JsonApiName("name")]
  public string? Name { get; init; }

  /// <summary>
  /// An array of objects.
  /// 
  /// <c>
  /// {
  /// "name": "My Alternate Key",
  /// "key": "B"
  /// }
  /// </c>
  /// </summary>
  [JsonApiName("alternate_keys")]
  public string? AlternateKeys { get; init; }

  /// <summary>
  /// Possible Values:
  /// 
  /// <c>Ab</c>, <c>A</c>, <c>A#</c>, <c>Bb</c>, <c>B</c>, <c>C</c>, <c>C#</c>, <c>Db</c>, <c>D</c>, <c>D#</c>, <c>Eb</c>, <c>E</c>, <c>F</c>, <c>F#</c>, <c>Gb</c>, <c>G</c>, <c>G#</c>, <c>Abm</c>, <c>Am</c>, <c>A#m</c>, <c>Bbm</c>, <c>Bm</c>, <c>Cm</c>, <c>C#m</c>, <c>Dbm</c>, <c>Dm</c>, <c>D#m</c>, <c>Ebm</c>, <c>Em</c>, <c>Fm</c>, <c>F#m</c>, <c>Gbm</c>, <c>Gm</c>, <c>G#m</c>
  /// 
  /// To set the key to minor append <c>m</c> to the key. e.g. <c>Cm</c>
  /// </summary>
  [JsonApiName("ending_key")]
  public string? EndingKey { get; init; }

  /// <summary>
  /// Possible Values:
  /// 
  /// <c>Ab</c>, <c>A</c>, <c>A#</c>, <c>Bb</c>, <c>B</c>, <c>C</c>, <c>C#</c>, <c>Db</c>, <c>D</c>, <c>D#</c>, <c>Eb</c>, <c>E</c>, <c>F</c>, <c>F#</c>, <c>Gb</c>, <c>G</c>, <c>G#</c>, <c>Abm</c>, <c>Am</c>, <c>A#m</c>, <c>Bbm</c>, <c>Bm</c>, <c>Cm</c>, <c>C#m</c>, <c>Dbm</c>, <c>Dm</c>, <c>D#m</c>, <c>Ebm</c>, <c>Em</c>, <c>Fm</c>, <c>F#m</c>, <c>Gbm</c>, <c>Gm</c>, <c>G#m</c>
  /// 
  /// To set the key to minor append <c>m</c> to the key. e.g. <c>Cm</c>
  /// </summary>
  [JsonApiName("starting_key")]
  public string? StartingKey { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("starting_minor")]
  public bool? StartingMinor { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("ending_minor")]
  public bool? EndingMinor { get; init; }

}
