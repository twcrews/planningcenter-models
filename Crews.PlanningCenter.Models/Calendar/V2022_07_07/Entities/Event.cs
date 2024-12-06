using System.Text.Json;

namespace Crews.PlanningCenter.Models.Calendar.V2022_07_07.Entities;

/// <summary>
/// An event.
/// 
/// May contain information such as who owns
/// the event, visibility on Church Center and a public-facing summary.
/// </summary>
[JsonApiName("event")]
public record Event
{
  /// <summary>
  /// Unique identifier for the event
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Possible values:
  /// - <c>A</c>: approved.
  /// - <c>P</c>: pending.
  /// - <c>R</c>: rejected.
  /// </summary>
  [JsonApiName("approval_status")]
  public string? ApprovalStatus { get; init; }

  /// <summary>
  /// UTC time at which the event was created
  /// </summary>
  [JsonApiName("created_at")]
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// A rich text public-facing summary of the event
  /// </summary>
  [JsonApiName("description")]
  public string? Description { get; init; }

  /// <summary>
  /// - <c>true</c> indicates the event is featured on Church Center
  /// - <c>false</c> indicates the event is not featured on Church Center
  /// </summary>
  [JsonApiName("featured")]
  public bool? Featured { get; init; }

  /// <summary>
  /// Path to where the event image is stored
  /// </summary>
  [JsonApiName("image_url")]
  public string? ImageUrl { get; init; }

  /// <summary>
  /// The name of the event
  /// </summary>
  [JsonApiName("name")]
  public string? Name { get; init; }

  /// <summary>
  /// Calculated by taking the sum of the <c>percent_approved</c> for all
  /// future <c>ReservationBlocks</c> and dividing that by the <c>count</c> of all future
  /// <c>ReservationBlocks</c>.
  /// 
  /// If there are no future <c>ReservationBlocks</c>, returns <c>100</c>
  /// </summary>
  [JsonApiName("percent_approved")]
  public int? PercentApproved { get; init; }

  /// <summary>
  /// Calculated by taking the sum of the <c>percent_rejected</c> for all
  /// future <c>ReservationBlocks</c> and dividing that by the <c>count</c> of all future
  /// <c>ReservationBlocks</c>.
  /// 
  /// If there are no future <c>ReservationBlocks</c>, returns <c>0</c>
  /// </summary>
  [JsonApiName("percent_rejected")]
  public int? PercentRejected { get; init; }

  /// <summary>
  /// The registration URL for the event
  /// </summary>
  [JsonApiName("registration_url")]
  public string? RegistrationUrl { get; init; }

  /// <summary>
  /// A plain text public-facing summary of the event
  /// </summary>
  [JsonApiName("summary")]
  public string? Summary { get; init; }

  /// <summary>
  /// UTC time at which the event was updated
  /// </summary>
  [JsonApiName("updated_at")]
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// - <c>true</c> indicates the event Church Center visibility is set to 'Published'
  /// - <c>false</c> indicates the event Church Center visibility is set to 'Hidden'
  /// </summary>
  [JsonApiName("visible_in_church_center")]
  public bool? VisibleInChurchCenter { get; init; }

}
