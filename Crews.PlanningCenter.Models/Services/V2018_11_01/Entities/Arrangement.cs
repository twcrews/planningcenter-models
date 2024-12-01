using System.Text.Json;

namespace Crews.PlanningCenter.Models.Services.V2018_11_01.Entities;

/// <summary>
/// Each arrangement belongs to a song and is a different version of that song.
/// </summary>
public record Arrangement
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public double? Bpm { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public bool? HasChords { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public int? Length { get; init; }

  /// <summary>
  /// Possible Values:
  /// 
  /// - `2/2`
  /// 
  /// - `2/4`
  /// 
  /// - `3/2`
  /// 
  /// - `3/4`
  /// 
  /// - `4/2`
  /// 
  /// - `4/4`
  /// 
  /// - `5/4`
  /// 
  /// - `6/4`
  /// 
  /// - `3/8`
  /// 
  /// - `6/8`
  /// 
  /// - `7/4`
  /// 
  /// - `7/8`
  /// 
  /// - `9/8`
  /// 
  /// - `12/4`
  /// 
  /// - `12/8`
  /// 
  /// </summary>
  public string? Meter { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Name { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Notes { get; init; }

  /// <summary>
  /// Possible Values:
  /// 
  /// - `0.0in`
  /// 
  /// - `0.25in`
  /// 
  /// - `0.5in`
  /// 
  /// - `0.75in`
  /// 
  /// - `1.0in`
  /// 
  /// </summary>
  public string? PrintMargin { get; init; }

  /// <summary>
  /// Possible Values:
  /// 
  /// - `Portrait`
  /// 
  /// - `Landscape`
  /// 
  /// </summary>
  public string? PrintOrientation { get; init; }

  /// <summary>
  /// Possible Values:
  /// 
  /// - `Widescreen (16x9)`
  /// 
  /// - `Fullscreen (4x3)`
  /// 
  /// - `A4`
  /// 
  /// - `Letter`
  /// 
  /// - `Legal`
  /// 
  /// - `11x17`
  /// 
  /// </summary>
  public string? PrintPageSize { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// A string of lyrics and chords. Supports standard and ChordPro formats.
  /// 
  /// </summary>
  public string? ChordChart { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? ChordChartFont { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? ChordChartKey { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public int? ChordChartColumns { get; init; }

  /// <summary>
  /// Possible Values:
  /// 
  /// `10`, `11`, `12`, `13`, `14`, `15`, `16`, `18`, `20`, `22`, `24`, `26`, `28`, `32`, `36`, `42`, `48`
  /// 
  /// </summary>
  public int? ChordChartFontSize { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public bool? HasChordChart { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public bool? LyricsEnabled { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public bool? NumberChartEnabled { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public bool? NumeralChartEnabled { get; init; }

  /// <summary>
  /// An array of strings containing a label and a number describing the section:
  /// 
  /// ['Verse 1', 'Chorus 1', 'Verse 2']
  /// 
  /// </summary>
  public IEnumerable<JsonElement>? Sequence { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public IEnumerable<JsonElement>? SequenceShort { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public IEnumerable<JsonElement>? SequenceFull { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public int? ChordChartChordColor { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? ArchivedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Lyrics { get; init; }

}
