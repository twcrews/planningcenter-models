using System.Text.Json;

namespace Crews.PlanningCenter.Models.Groups.V2018_08_01.Entities;

/// <summary>
/// A group application is a request to join a group which can be approved or rejected.
/// 
/// </summary>
public record GroupApplication
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// Timestamp when this person applied.
  /// 
  /// </summary>
  public DateTime? AppliedAt { get; init; }

  /// <summary>
  /// An optional personal message from the applicant.
  /// 
  /// </summary>
  public string? Message { get; init; }

  /// <summary>
  /// The approval status of the application.
  /// 
  /// Possible values: `pending`, `approved`, or `rejected`
  /// 
  /// </summary>
  public string? Status { get; init; }

}
