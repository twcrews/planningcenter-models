namespace Crews.PlanningCenter.Models.Calendar.V2018_08_01.Entities;

/// <summary>
/// A room or resource that can be requested for use as part of
/// an event.
/// </summary>
public record Resource
{
  /// <summary>
  /// Unique identifier for the room or resource
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// UTC time at which the room or resource was created
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// The type of resource, can either be <c>Room</c> or <c>Resource</c>
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
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Path { get; init; }

}
