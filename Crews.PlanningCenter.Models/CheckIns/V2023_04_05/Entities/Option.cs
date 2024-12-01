using System.Text.Json;

namespace Crews.PlanningCenter.Models.CheckIns.V2023_04_05.Entities;

/// <summary>
/// An option which an attendee may select when checking in.
/// 
/// Options may have extra labels associated with them, denoted by `label` and `quantity`.
/// 
/// </summary>
public record Option
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Body { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public int? Quantity { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

}
