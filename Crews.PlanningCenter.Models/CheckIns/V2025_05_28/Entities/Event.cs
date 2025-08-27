using System.Text.Json;

namespace Crews.PlanningCenter.Models.CheckIns.V2025_05_28.Entities;

/// <summary>
/// A recurring event which people may attend.
/// 
/// Each recurrence is an _event period_ (which often corresponds to a week).
/// 
/// Event periods have _event times_ where people may actually check in.
/// </summary>
[JsonApiName("event")]
public record Event
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("name")]
  public string? Name { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("frequency")]
  public string? Frequency { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("enable_services_integration")]
  public bool? EnableServicesIntegration { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("created_at")]
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("updated_at")]
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("archived_at")]
  public DateTime? ArchivedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("integration_key")]
  public string? IntegrationKey { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("location_times_enabled")]
  public bool? LocationTimesEnabled { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("pre_select_enabled")]
  public bool? PreSelectEnabled { get; init; }

  /// <summary>
  /// Only available when requested with the <c>?fields</c> param
  /// </summary>
  [JsonApiName("app_source")]
  public string? AppSource { get; init; }

}
