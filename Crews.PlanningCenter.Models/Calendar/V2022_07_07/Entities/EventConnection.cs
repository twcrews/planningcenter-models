using System.Text.Json;

namespace Crews.PlanningCenter.Models.Calendar.V2022_07_07.Entities;

/// <summary>
/// A connection between a Calendar event and a record in another product
/// </summary>
[JsonApiName("event_connection")]
public record EventConnection
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Unique identifier for the connected record
  /// </summary>
  [JsonApiName("connected_to_id")]
  public string? ConnectedToId { get; init; }

  /// <summary>
  /// Name of the record that the event is connected to
  /// </summary>
  [JsonApiName("connected_to_name")]
  public string? ConnectedToName { get; init; }

  /// <summary>
  /// Currently we support <c>signup</c>, <c>group</c>, <c>event</c>, and <c>service_type</c>
  /// </summary>
  [JsonApiName("connected_to_type")]
  public string? ConnectedToType { get; init; }

  /// <summary>
  /// Currently we support <c>registrations</c>, <c>groups</c>, <c>check-ins</c>, and <c>services</c>
  /// </summary>
  [JsonApiName("product_name")]
  public string? ProductName { get; init; }

  /// <summary>
  /// A link to the connected record
  /// </summary>
  [JsonApiName("connected_to_url")]
  public string? ConnectedToUrl { get; init; }

}
