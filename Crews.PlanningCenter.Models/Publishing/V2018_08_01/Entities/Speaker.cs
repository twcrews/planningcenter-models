using System.Text.Json;

namespace Crews.PlanningCenter.Models.Publishing.V2018_08_01.Entities;

/// <summary>
/// Planning Center does not provide a description for this resource.
/// </summary>
public record Speaker
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? AvatarUrl { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public int? EpisodesCount { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? FirstName { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? FormattedName { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? LastName { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? NamePrefix { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? NameSuffix { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? SpeakerType { get; init; }

}