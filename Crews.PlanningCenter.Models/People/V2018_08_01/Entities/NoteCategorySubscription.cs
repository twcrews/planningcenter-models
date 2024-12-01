using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2018_08_01.Entities;

/// <summary>
/// A subscription for note categories
/// </summary>
public record NoteCategorySubscription
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

}