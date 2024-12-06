using System.Text.Json;

namespace Crews.PlanningCenter.Models.Services.V2018_08_01.Entities;

/// <summary>
/// Sections of an Arrangement, derived from its chord chart
/// </summary>
[JsonApiName("arrangement_sections")]
public record ArrangementSections
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Given an arrangement with the folowing <c>chord_chart</c>:
  /// 
  /// ``<c>
  /// VERSE 1
  /// D          Bm       G          D
  /// Be thou my vision O Lord of my heart
  /// A             Bm         G              A
  /// naught be all else to me save that Thou art
  /// </c>`<c>
  /// 
  /// The value will be:
  /// 
  /// </c>`<c>json
  /// [
  /// {
  /// "label": "Verse",
  /// "lyrics": "Be thou my vision O Lord of my heart
  /// naught be all else to me save that Thou art",
  /// "breaks_at": null
  /// }
  /// ]
  /// </c>``
  /// </summary>
  [JsonApiName("sections")]
  public IEnumerable<JsonElement>? Sections { get; init; }

}
