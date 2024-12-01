using System.Text.Json;

namespace Crews.PlanningCenter.Models.Calendar.V2021_07_20.Entities;

/// <summary>
/// A room or resource that can be requested for use as part of
/// an event.
/// 
/// </summary>
public record Resource
{
  /// <summary>
  /// Unique identifier for the room or resource
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// UTC time at which the room or resource was created
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// The type of resource, can either be `Room` or `Resource`
  /// </summary>
  public string? Kind { get; init; }

  /// <summary>
  /// The name of the room or resource
  /// </summary>
  public string? Name { get; init; }

  /// <summary>
  /// The serial number of the resource
  /// </summary>
  public string? SerialNumber { get; init; }

  /// <summary>
  /// UTC time at which the room or resource was updated
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// Description of the room or resource
  /// </summary>
  public string? Description { get; init; }

  /// <summary>
  /// UTC time at which the resource expires
  /// </summary>
  public DateTime? ExpiresAt { get; init; }

  /// <summary>
  /// Where the resource is normally kept
  /// </summary>
  public string? HomeLocation { get; init; }

  /// <summary>
  /// Path to where resource image is stored
  /// </summary>
  public string? Image { get; init; }

  /// <summary>
  /// The quantity of the resource
  /// </summary>
  public int? Quantity { get; init; }

  /// <summary>
  /// A string representing the location of the resource if it is nested within a folder.
  /// 
  /// Each parent folder is separated by `/`
  /// 
  /// </summary>
  public string? PathName { get; init; }

}