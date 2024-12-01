using System.Text.Json;

namespace Crews.PlanningCenter.Models.Groups.V2018_08_01.Entities;

/// <summary>
/// The owner/creator of an event note.
/// 
/// </summary>
public record Owner
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// The URL of the person's avatar.
  /// 
  /// </summary>
  public string? AvatarUrl { get; init; }

  /// <summary>
  /// The person's first name.
  /// 
  /// </summary>
  public string? FirstName { get; init; }

  /// <summary>
  /// The person's last name.
  /// 
  /// </summary>
  public string? LastName { get; init; }

}
