using System.Text.Json;

namespace Crews.PlanningCenter.Models.Calendar.V2020_04_08.Entities;

/// <summary>
/// An organizational folder containing rooms or resources.
/// 
/// </summary>
public record ResourceFolder
{
  /// <summary>
  /// Unique identifier for the folder
  /// </summary>
  public string? Id { get; init; }

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
  /// The type of folder, can either be `Room` or `Resource`
  /// </summary>
  public string? Kind { get; init; }

  /// <summary>
  /// A string representing the location of the folder if it is nested.
  /// 
  /// Each parent folder is separated by `/`
  /// 
  /// </summary>
  public string? PathName { get; init; }

}
