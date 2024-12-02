using System.Text.Json;

namespace Crews.PlanningCenter.Models.Services.V2018_11_01.Entities;

/// <summary>
/// A position within a team.
/// </summary>
public record TeamPosition
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Name { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public int? Sequence { get; init; }

  /// <summary>
  /// If the Team is assigned via tags, these are specific Tags that are specified.
  /// </summary>
  public IEnumerable<JsonElement>? Tags { get; init; }

  /// <summary>
  /// If the Team is assigned via tags, these are Tags where the option "None" is specified.
  /// </summary>
  public IEnumerable<JsonElement>? NegativeTagGroups { get; init; }

  /// <summary>
  /// If the Team is assigned via tags, these are Tags where the option "Any" is specified.
  /// </summary>
  public IEnumerable<JsonElement>? TagGroups { get; init; }

}
