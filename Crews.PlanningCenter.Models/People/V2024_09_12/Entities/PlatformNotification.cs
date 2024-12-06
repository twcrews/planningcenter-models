using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2024_09_12.Entities;

/// <summary>
/// A Platform Notification is a suite-wide notification that shows at the top of each application's screen until dismissed by the user.
/// </summary>
[JsonApiName("platform_notification")]
public record PlatformNotification
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("html")]
  public string? Html { get; init; }

}
