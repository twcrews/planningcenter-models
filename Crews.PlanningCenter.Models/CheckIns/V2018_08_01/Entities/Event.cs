using System.Text.Json;

namespace Crews.PlanningCenter.Models.CheckIns.V2018_08_01.Entities;

/// <summary>
/// A recurring event which people may attend.
/// 
/// Each recurrence is an _event period_ (which often corresponds to a week).
/// 
/// Event periods have _event times_ where people may actually check in.
/// 
/// </summary>
public record Event
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Name { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Frequency { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public bool? EnableServicesIntegration { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? ArchivedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? IntegrationKey { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public bool? LocationTimesEnabled { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public bool? PreSelectEnabled { get; init; }

  /// <summary>
  /// Only available when requested with the `?fields` param
  /// </summary>
  public string? AppSource { get; init; }

}
