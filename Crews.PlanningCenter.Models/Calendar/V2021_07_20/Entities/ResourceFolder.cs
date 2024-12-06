using System.Text.Json;

namespace Crews.PlanningCenter.Models.Calendar.V2021_07_20.Entities;

/// <summary>
/// An organizational folder containing rooms or resources.
/// </summary>
[JsonApiName("resource_folder")]
public record ResourceFolder
{
  /// <summary>
  /// Unique identifier for the folder
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// UTC time at which the folder was created
  /// </summary>
  [JsonApiName("created_at")]
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// The folder name
  /// </summary>
  [JsonApiName("name")]
  public string? Name { get; init; }

  /// <summary>
  /// UTC time at which the folder was updated
  /// </summary>
  [JsonApiName("updated_at")]
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("ancestry")]
  public string? Ancestry { get; init; }

  /// <summary>
  /// The type of folder, can either be <c>Room</c> or <c>Resource</c>
  /// </summary>
  [JsonApiName("kind")]
  public string? Kind { get; init; }

  /// <summary>
  /// A string representing the location of the folder if it is nested.
  /// 
  /// Each parent folder is separated by <c>/</c>
  /// </summary>
  [JsonApiName("path_name")]
  public string? PathName { get; init; }

}
