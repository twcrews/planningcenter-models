using System.Text.Json;

namespace Crews.PlanningCenter.Models.Publishing.V2018_08_01.Entities;

/// <summary>
/// Planning Center does not provide a description for this resource.
/// </summary>
public record Series
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public JsonElement? Art { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? ChurchCenterUrl { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Description { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? EndedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public int? EpisodesCount { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public bool? Published { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? StartedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Title { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

}