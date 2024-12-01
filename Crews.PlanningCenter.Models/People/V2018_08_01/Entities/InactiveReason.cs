using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2018_08_01.Entities;

/// <summary>
/// An inactive reason is a small bit of text indicating why a member is no longer active.
/// </summary>
public record InactiveReason
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Value { get; init; }

}
