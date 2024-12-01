using System.Text.Json;

namespace Crews.PlanningCenter.Models.Services.V2018_11_01.Entities;

/// <summary>
/// Sections of an Arrangement, derived from its chord chart
/// </summary>
public record ArrangementSections
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// Given an arrangement with the folowing `chord_chart`:
  /// 
  /// ```
  /// VERSE 1
  /// D          Bm       G          D
  /// Be thou my vision O Lord of my heart
  /// A             Bm         G              A
  /// naught be all else to me save that Thou art
  /// ```
  /// 
  /// The value will be:
  /// 
  /// ```json
  /// [
  /// {
  /// "label": "Verse",
  /// "lyrics": "Be thou my vision O Lord of my heart
  /// naught be all else to me save that Thou art",
  /// "breaks_at": null
  /// }
  /// ]
  /// ```
  /// 
  /// </summary>
  public IEnumerable<JsonElement>? Sections { get; init; }

}
