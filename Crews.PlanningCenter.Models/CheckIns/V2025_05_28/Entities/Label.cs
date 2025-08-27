using System.Text.Json;

namespace Crews.PlanningCenter.Models.CheckIns.V2025_05_28.Entities;

/// <summary>
/// Labels can be set to print for events (through <c>EventLabel</c>s),
/// locations (through <c>LocationLabel</c>s) or options.
/// Label type (security label / name label) is expressed with the
/// <c>prints_for</c> attribute. <c>prints_for="Person"</c> is a name label,
/// <c>prints_for="Group"</c> is a security label.
/// </summary>
[JsonApiName("label")]
public record Label
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("name")]
  public string? Name { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("xml")]
  public string? Xml { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("prints_for")]
  public string? PrintsFor { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("roll")]
  public string? Roll { get; init; }

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

}
