using System.Text.Json;

namespace Crews.PlanningCenter.Models.Groups.V2023_07_10.Entities;

/// <summary>
/// The state of a <c>Person</c> belonging to a <c>Group</c>.
/// 
/// A <c>Person</c> can only have one active <c>Membership</c> to a <c>Group</c> at a time.
/// </summary>
[JsonApiName("membership")]
public record Membership
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// The date and time the person joined the group.
  /// </summary>
  [JsonApiName("joined_at")]
  public DateTime? JoinedAt { get; init; }

  /// <summary>
  /// The role of the person in the group.
  /// Possible values: <c>member</c> or <c>leader</c>
  /// </summary>
  [JsonApiName("role")]
  public string? Role { get; init; }

}
