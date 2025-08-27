using System.Text.Json;

namespace Crews.PlanningCenter.Models.CheckIns.V2025_05_28.Entities;

/// <summary>
/// An option which an attendee may select when checking in.
/// 
/// Options may have extra labels associated with them, denoted by <c>label</c> and <c>quantity</c>.
/// </summary>
[JsonApiName("option")]
public record Option
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("body")]
  public string? Body { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("quantity")]
  public int? Quantity { get; init; }

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
