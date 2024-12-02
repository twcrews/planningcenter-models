namespace Crews.PlanningCenter.Models.Calendar.V2022_07_07.Entities;

/// <summary>
/// A connection between a Calendar event and a record in another product
/// </summary>
public record EventConnection
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// Unique identifier for the connected record
  /// </summary>
  public string? ConnectedToId { get; init; }

  /// <summary>
  /// Name of the record that the event is connected to
  /// </summary>
  public string? ConnectedToName { get; init; }

  /// <summary>
  /// Currently we support <c>signup</c>, <c>group</c>, <c>event</c>, and <c>service_type</c>
  /// </summary>
  public string? ConnectedToType { get; init; }

  /// <summary>
  /// Currently we support <c>registrations</c>, <c>groups</c>, <c>check-ins</c>, and <c>services</c>
  /// </summary>
  public string? ProductName { get; init; }

  /// <summary>
  /// A link to the connected record
  /// </summary>
  public string? ConnectedToUrl { get; init; }

}
