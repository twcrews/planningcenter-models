using System.Text.Json;

namespace Crews.PlanningCenter.Models.CheckIns.V2023_04_05.Entities;

/// <summary>
/// Says how many of a given label to print for this location and
/// whether to print it for regulars, guests, and/or volunteers.
/// </summary>
[JsonApiName("location_label")]
public record LocationLabel
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("quantity")]
  public int? Quantity { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("for_regular")]
  public bool? ForRegular { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("for_guest")]
  public bool? ForGuest { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("for_volunteer")]
  public bool? ForVolunteer { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("created_at")]
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("updated_at")]
  public DateTime? UpdatedAt { get; init; }

}
