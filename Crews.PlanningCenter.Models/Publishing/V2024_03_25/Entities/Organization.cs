using System.Text.Json;

namespace Crews.PlanningCenter.Models.Publishing.V2024_03_25.Entities;

/// <summary>
/// Planning Center does not provide a description for this resource.
/// </summary>
public record Organization
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
  public string? Subdomain { get; init; }

  /// <summary>
  /// Only available when requested with the `?fields` param
  /// </summary>
  public int? DownloadsUsed { get; init; }

}
