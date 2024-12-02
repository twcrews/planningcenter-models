using System.Text.Json;

namespace Crews.PlanningCenter.Models.Calendar.V2022_07_07.Entities;

/// <summary>
/// An organizational folder containing rooms or resources.
/// </summary>
public record ResourceFolder
{
  /// <summary>
  /// Unique identifier for the folder
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// UTC time at which the folder was created
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// The folder name
  /// </summary>
  public string? Name { get; init; }

  /// <summary>
  /// UTC time at which the folder was updated
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Ancestry { get; init; }

  /// <summary>
  /// The type of folder, can either be <c>Room</c> or <c>Resource</c>
  /// </summary>
  public string? Kind { get; init; }

  /// <summary>
  /// A string representing the location of the folder if it is nested.
  /// 
  /// Each parent folder is separated by <c>/</c>
  /// </summary>
  public string? PathName { get; init; }

}
