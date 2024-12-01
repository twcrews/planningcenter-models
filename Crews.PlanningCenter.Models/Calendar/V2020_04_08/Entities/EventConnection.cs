using System.Text.Json;

namespace Crews.PlanningCenter.Models.Calendar.V2020_04_08.Entities;

/// <summary>
/// A connection between a Calendar event and a record in another product
/// 
/// </summary>
public record EventConnection
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// Unique identifier for the connected record
  /// </summary>
  public string? ConnectedToId { get; init; }

  /// <summary>
  /// Name of the record that the event is connected to
  /// </summary>
  public string? ConnectedToName { get; init; }

  /// <summary>
  /// Currently we support `signup`, `group`, `event`, and `service_type`
  /// </summary>
  public string? ConnectedToType { get; init; }

  /// <summary>
  /// Currently we support `registrations`, `groups`, `check-ins`, and `services`
  /// </summary>
  public string? ProductName { get; init; }

  /// <summary>
  /// A link to the connected record
  /// </summary>
  public string? ConnectedToUrl { get; init; }

}
