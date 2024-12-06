using System.Text.Json;

namespace Crews.PlanningCenter.Models.Groups.V2018_08_01.Entities;

/// <summary>
/// A group application is a request to join a group which can be approved or rejected.
/// </summary>
[JsonApiName("group_application")]
public record GroupApplication
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Timestamp when this person applied.
  /// </summary>
  [JsonApiName("applied_at")]
  public DateTime? AppliedAt { get; init; }

  /// <summary>
  /// An optional personal message from the applicant.
  /// </summary>
  [JsonApiName("message")]
  public string? Message { get; init; }

  /// <summary>
  /// The approval status of the application.
  /// 
  /// Possible values: <c>pending</c>, <c>approved</c>, or <c>rejected</c>
  /// </summary>
  [JsonApiName("status")]
  public string? Status { get; init; }

}
