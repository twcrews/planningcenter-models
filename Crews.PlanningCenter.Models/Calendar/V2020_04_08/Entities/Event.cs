namespace Crews.PlanningCenter.Models.Calendar.V2020_04_08.Entities;

/// <summary>
/// An event.
/// 
/// May contain information such as who owns
/// the event, visibility on Church Center and a public-facing summary.
/// </summary>
public record Event
{
  /// <summary>
  /// Unique identifier for the event
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// Possible values:
  /// - <c>A</c>: approved.
  /// - <c>P</c>: pending.
  /// - <c>R</c>: rejected.
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
  /// Calculated by taking the sum of the <c>percent_approved</c> for all
  /// future <c>ReservationBlocks</c> and dividing that by the <c>count</c> of all future
  /// <c>ReservationBlocks</c>.
  /// 
  /// If there are no future <c>ReservationBlocks</c>, returns <c>100</c>
  /// </summary>
  public int? PercentApproved { get; init; }

  /// <summary>
  /// Calculated by taking the sum of the <c>percent_rejected</c> for all
  /// future <c>ReservationBlocks</c> and dividing that by the <c>count</c> of all future
  /// <c>ReservationBlocks</c>.
  /// 
  /// If there are no future <c>ReservationBlocks</c>, returns <c>0</c>
  /// </summary>
  public int? PercentRejected { get; init; }

  /// <summary>
  /// The registration URL for the event
  /// </summary>
  public string? RegistrationUrl { get; init; }

  /// <summary>
  /// UTC time at which the event was updated
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// - <c>true</c> indicates the event Church Center visibility is set to 'Published'
  /// - <c>false</c> indicates the event Church Center visibility is set to 'Hidden'
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
