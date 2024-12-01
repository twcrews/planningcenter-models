using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2022_07_14.Entities;

/// <summary>
/// A Platform Notification is a suite-wide notification that shows at the top of each application's screen until dismissed by the user.
/// </summary>
public record PlatformNotification
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Html { get; init; }

}
