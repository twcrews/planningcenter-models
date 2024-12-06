using System.Text.Json;

namespace Crews.PlanningCenter.Models.CheckIns.V2019_07_17.Entities;

/// <summary>
/// A record linking another product's resource to a Check-Ins resource.
/// </summary>
[JsonApiName("integration_link")]
public record IntegrationLink
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// The Global ID for the external resource. Formatted as <c>gid://{app}/{type}/{id}</c>.
  /// </summary>
  [JsonApiName("remote_gid")]
  public string? RemoteGid { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("remote_app")]
  public string? RemoteApp { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("remote_type")]
  public string? RemoteType { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("remote_id")]
  public string? RemoteId { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("sync_future_assignment_types")]
  public bool? SyncFutureAssignmentTypes { get; init; }

}
