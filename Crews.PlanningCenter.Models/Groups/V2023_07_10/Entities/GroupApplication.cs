using System.Text.Json;

namespace Crews.PlanningCenter.Models.Groups.V2023_07_10.Entities;

/// <summary>
/// A group application is a request to join a group which can be approved or rejected.
/// </summary>
public record GroupApplication
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// Timestamp when this person applied.
  /// </summary>
  public DateTime? AppliedAt { get; init; }

  /// <summary>
  /// An optional personal message from the applicant.
  /// </summary>
  public string? Message { get; init; }

  /// <summary>
  /// The approval status of the application.
  /// 
  /// Possible values: <c>pending</c>, <c>approved</c>, or <c>rejected</c>
  /// </summary>
  public string? Status { get; init; }

}
