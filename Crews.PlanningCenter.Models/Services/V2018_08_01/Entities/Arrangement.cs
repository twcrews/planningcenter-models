using System.Text.Json;

namespace Crews.PlanningCenter.Models.Services.V2018_08_01.Entities;

/// <summary>
/// Each arrangement belongs to a song and is a different version of that song.
/// </summary>
public record Arrangement
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? ID { get; init; }

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
  /// - <c>2/2</c>
  /// 
  /// - <c>2/4</c>
  /// 
  /// - <c>3/2</c>
  /// 
  /// - <c>3/4</c>
  /// 
  /// - <c>4/2</c>
  /// 
  /// - <c>4/4</c>
  /// 
  /// - <c>5/4</c>
  /// 
  /// - <c>6/4</c>
  /// 
  /// - <c>3/8</c>
  /// 
  /// - <c>6/8</c>
  /// 
  /// - <c>7/4</c>
  /// 
  /// - <c>7/8</c>
  /// 
  /// - <c>9/8</c>
  /// 
  /// - <c>12/4</c>
  /// 
  /// - <c>12/8</c>
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
  /// - <c>0.0in</c>
  /// 
  /// - <c>0.25in</c>
  /// 
  /// - <c>0.5in</c>
  /// 
  /// - <c>0.75in</c>
  /// 
  /// - <c>1.0in</c>
  /// </summary>
  public string? PrintMargin { get; init; }

  /// <summary>
  /// Possible Values:
  /// 
  /// - <c>Portrait</c>
  /// 
  /// - <c>Landscape</c>
  /// </summary>
  public string? PrintOrientation { get; init; }

  /// <summary>
  /// Possible Values:
  /// 
  /// - <c>Widescreen (16x9)</c>
  /// 
  /// - <c>Fullscreen (4x3)</c>
  /// 
  /// - <c>A4</c>
  /// 
  /// - <c>Letter</c>
  /// 
  /// - <c>Legal</c>
  /// 
  /// - <c>11x17</c>
  /// </summary>
  public string? PrintPageSize { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// A string of lyrics and chords. Supports standard and ChordPro formats.
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
  /// <c>10</c>, <c>11</c>, <c>12</c>, <c>13</c>, <c>14</c>, <c>15</c>, <c>16</c>, <c>18</c>, <c>20</c>, <c>22</c>, <c>24</c>, <c>26</c>, <c>28</c>, <c>32</c>, <c>36</c>, <c>42</c>, <c>48</c>
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
