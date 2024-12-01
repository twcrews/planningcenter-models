using System.Text.Json;

namespace Crews.PlanningCenter.Models.Calendar.V2022_07_07.Entities;

/// <summary>
/// A feed belonging to an organization.
/// 
/// </summary>
public record Feed
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public bool? CanDelete { get; init; }

  /// <summary>
  /// Possible values: `hidden` or `published`
  /// </summary>
  public string? DefaultChurchCenterVisibility { get; init; }

  /// <summary>
  /// Possible values: `registrations`, `groups`, `ical`, or `form`
  /// </summary>
  public string? FeedType { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? ImportedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Name { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? SourceId { get; init; }

}
