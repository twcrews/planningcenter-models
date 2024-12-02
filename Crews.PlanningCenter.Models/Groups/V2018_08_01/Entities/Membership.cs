using System.Text.Json;

namespace Crews.PlanningCenter.Models.Groups.V2018_08_01.Entities;

/// <summary>
/// A person who belongs to a group.
/// </summary>
public record Membership
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// The date and time the person joined the group.
  /// </summary>
  public DateTime? JoinedAt { get; init; }

  /// <summary>
  /// The role of the person in the group.
  /// Possible values: <c>member</c> or <c>leader</c>
  /// </summary>
  public string? Role { get; init; }

  /// <summary>
  /// The ID of the person in People.
  /// </summary>
  public string? AccountCenterIdentifier { get; init; }

  /// <summary>
  /// The URL of the person's avatar.
  /// </summary>
  public string? AvatarUrl { get; init; }

  /// <summary>
  /// The person's primary email address.
  /// </summary>
  public string? EmailAddress { get; init; }

  /// <summary>
  /// The person's first name.
  /// </summary>
  public string? FirstName { get; init; }

  /// <summary>
  /// The person's last name.
  /// </summary>
  public string? LastName { get; init; }

  /// <summary>
  /// The person's primary phone number.
  /// </summary>
  public string? PhoneNumber { get; init; }

  /// <summary>
  /// The color theme of the group's group type.
  /// </summary>
  public int? ColorIdentifier { get; init; }

}
