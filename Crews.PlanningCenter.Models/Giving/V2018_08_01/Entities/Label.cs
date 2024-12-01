using System.Text.Json;

namespace Crews.PlanningCenter.Models.Giving.V2018_08_01.Entities;

/// <summary>
/// A `Label` is a way for Admins to manage and categorize `Donation`s.
/// 
/// Multiple `Label`s can be added for each `Donation`, and these will only be displayed in the Giving admin interface, so donors never see them.
/// 
/// </summary>
public record Label
{
  /// <summary>
  /// The unique identifier for a label.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// The label text itself. Made up solely of lowercase letters, numbers, and dashes. When creating or updating a label, the string you provide will be formatted automatically. For example: `My awesome label!` will be saved as `my-awesome-label`
  /// </summary>
  public string? Slug { get; init; }

}
