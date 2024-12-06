using System.Text.Json;

namespace Crews.PlanningCenter.Models.Groups.V2018_08_01.Entities;

/// <summary>
/// The owner/creator of an event note.
/// </summary>
[JsonApiName("owner")]
public record Owner
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// The URL of the person's avatar.
  /// </summary>
  [JsonApiName("avatar_url")]
  public string? AvatarUrl { get; init; }

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

}
