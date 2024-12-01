using System.Text.Json;

namespace Crews.PlanningCenter.Models.Calendar.V2018_08_01.Entities;

/// <summary>
/// An event.
/// 
/// May contain information such as who owns
/// the event, visibility on Church Center and a public-facing summary.
/// 
/// </summary>
public record Event
{
  /// <summary>
  /// Unique identifier for the event
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// Possible values:
  /// - `A`: approved.
  /// - `P`: pending.
  /// - `R`: rejected.
  /// 
  /// </summary>
  public string? ApprovalStatus { get; init; }

  /// <summary>
  /// UTC time at which the event was created
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Path to where the event image is stored
  /// </summary>
  public string? ImageUrl { get; init; }

  /// <summary>
  /// The name of the event
  /// </summary>
  public string? Name { get; init; }

  /// <summary>
  /// Calculated by taking the sum of the `percent_approved` for all
  /// future `ReservationBlocks` and dividing that by the `count` of all future
  /// `ReservationBlocks`.
  /// 
  /// If there are no future `ReservationBlocks`, returns `100`
  /// 
  /// </summary>
  public int? PercentApproved { get; init; }

  /// <summary>
  /// Calculated by taking the sum of the `percent_rejected` for all
  /// future `ReservationBlocks` and dividing that by the `count` of all future
  /// `ReservationBlocks`.
  /// 
  /// If there are no future `ReservationBlocks`, returns `0`
  /// 
  /// </summary>
  public int? PercentRejected { get; init; }

  /// <summary>
  /// UTC time at which the event was updated
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// - `true` indicates the event Church Center visibility is set to 'Published'
  /// - `false` indicates the event Church Center visibility is set to 'Hidden'
  /// 
  /// </summary>
  public bool? VisibleInChurchCenter { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? ArchivedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Details { get; init; }

}
