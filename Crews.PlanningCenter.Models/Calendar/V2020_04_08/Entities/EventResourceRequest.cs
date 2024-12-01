using System.Text.Json;

namespace Crews.PlanningCenter.Models.Calendar.V2020_04_08.Entities;

/// <summary>
/// A room or resource request for a specific event.
/// 
/// </summary>
public record EventResourceRequest
{
  /// <summary>
  /// Unique identifier for the request
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// Whether or not an email has been sent to request approval
  /// </summary>
  public bool? ApprovalSent { get; init; }

  /// <summary>
  /// Possible values:
  /// - `A`: approved
  /// - `P`: pending
  /// - `R`: rejected
  /// 
  /// </summary>
  public string? ApprovalStatus { get; init; }

  /// <summary>
  /// UTC time at which request was created
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// UTC time at which request was updated
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// How many of the rooms or resources are being requested
  /// </summary>
  public int? Quantity { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public int? PercentApproved { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? RoomSetupInfo { get; init; }

}
