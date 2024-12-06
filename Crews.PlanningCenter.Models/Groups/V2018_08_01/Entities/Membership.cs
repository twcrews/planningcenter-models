using System.Text.Json;

namespace Crews.PlanningCenter.Models.Groups.V2018_08_01.Entities;

/// <summary>
/// A person who belongs to a group.
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

  /// <summary>
  /// The ID of the person in People.
  /// </summary>
  [JsonApiName("account_center_identifier")]
  public string? AccountCenterIdentifier { get; init; }

  /// <summary>
  /// The URL of the person's avatar.
  /// </summary>
  [JsonApiName("avatar_url")]
  public string? AvatarUrl { get; init; }

  /// <summary>
  /// The person's primary email address.
  /// </summary>
  [JsonApiName("email_address")]
  public string? EmailAddress { get; init; }

  /// <summary>
  /// The person's first name.
  /// </summary>
  [JsonApiName("first_name")]
  public string? FirstName { get; init; }

  /// <summary>
  /// The person's last name.
  /// </summary>
  [JsonApiName("last_name")]
  public string? LastName { get; init; }

  /// <summary>
  /// The person's primary phone number.
  /// </summary>
  [JsonApiName("phone_number")]
  public string? PhoneNumber { get; init; }

  /// <summary>
  /// The color theme of the group's group type.
  /// </summary>
  [JsonApiName("color_identifier")]
  public int? ColorIdentifier { get; init; }

}
