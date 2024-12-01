using System.Text.Json;

namespace Crews.PlanningCenter.Models.Groups.V2023_07_10.Entities;

/// <summary>
/// The state of a `Person` belonging to a `Group`.
/// 
/// A `Person` can only have one active `Membership` to a `Group` at a time.
/// 
/// </summary>
public record Membership
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// The date and time the person joined the group.
  /// 
  /// </summary>
  public DateTime? JoinedAt { get; init; }

  /// <summary>
  /// The role of the person in the group.
  /// Possible values: `member` or `leader`
  /// 
  /// </summary>
  public string? Role { get; init; }

}
