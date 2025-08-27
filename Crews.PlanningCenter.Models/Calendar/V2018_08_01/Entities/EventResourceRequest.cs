using System.Text.Json;

namespace Crews.PlanningCenter.Models.Calendar.V2018_08_01.Entities;

/// <summary>
/// A room or resource request for a specific event.
/// </summary>
[JsonApiName("event_resource_request")]
public record EventResourceRequest
{
  /// <summary>
  /// Unique identifier for the request
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Whether or not an email has been sent to request approval
  /// </summary>
  [JsonApiName("approval_sent")]
  public bool? ApprovalSent { get; init; }

  /// <summary>
  /// Possible values:
  /// - <c>A</c>: approved
  /// - <c>P</c>: pending
  /// - <c>R</c>: rejected
  /// </summary>
  [JsonApiName("approval_status")]
  public string? ApprovalStatus { get; init; }

  /// <summary>
  /// UTC time at which request was created
  /// </summary>
  [JsonApiName("created_at")]
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// UTC time at which request was updated
  /// </summary>
  [JsonApiName("updated_at")]
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// How many of the rooms or resources are being requested
  /// </summary>
  [JsonApiName("quantity")]
  public int? Quantity { get; init; }

  /// <summary>
  /// Whether this resource request is visible on kiosks
  /// </summary>
  [JsonApiName("visible_on_kiosks")]
  public bool? VisibleOnKiosks { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("percent_approved")]
  public int? PercentApproved { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("room_setup_info")]
  public string? RoomSetupInfo { get; init; }

}
