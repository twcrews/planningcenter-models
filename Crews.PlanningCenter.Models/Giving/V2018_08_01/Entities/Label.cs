using System.Text.Json;

namespace Crews.PlanningCenter.Models.Giving.V2018_08_01.Entities;

/// <summary>
/// A <c>Label</c> is a way for Admins to manage and categorize <c>Donation</c>s.
/// 
/// Multiple <c>Label</c>s can be added for each <c>Donation</c>, and these will only be displayed in the Giving admin interface, so donors never see them.
/// </summary>
public record Label
{
  /// <summary>
  /// The unique identifier for a label.
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// The label text itself. Made up solely of lowercase letters, numbers, and dashes. When creating or updating a label, the string you provide will be formatted automatically. For example: <c>My awesome label!</c> will be saved as <c>my-awesome-label</c>
  /// </summary>
  public string? Slug { get; init; }

}
