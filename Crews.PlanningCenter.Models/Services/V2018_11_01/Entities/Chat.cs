using System.Text.Json;

namespace Crews.PlanningCenter.Models.Services.V2018_11_01.Entities;

/// <summary>
/// Planning Center does not provide a description for this resource.
/// </summary>
public record Chat
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// Only available when requested with the `?fields` param
  /// </summary>
  public string? Payload { get; init; }

  /// <summary>
  /// Only available when requested with the `?fields` param
  /// </summary>
  public IEnumerable<JsonElement>? GroupIdentifiers { get; init; }

  /// <summary>
  /// Only available when requested with the `?fields` param
  /// </summary>
  public IEnumerable<JsonElement>? People { get; init; }

  /// <summary>
  /// Only available when requested with the `?fields` param
  /// </summary>
  public IEnumerable<JsonElement>? Plans { get; init; }

  /// <summary>
  /// Only available when requested with the `?fields` param
  /// </summary>
  public IEnumerable<JsonElement>? Teams { get; init; }

  /// <summary>
  /// Only available when requested with the `?fields` param
  /// </summary>
  public IEnumerable<JsonElement>? TeamsILead { get; init; }

}
