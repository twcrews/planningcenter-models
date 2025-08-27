using System.Text.Json;

namespace Crews.PlanningCenter.Models.Giving.V2018_08_01.Entities;

/// <summary>
/// The root level <c>Organization</c> record which serves as a link to <c>Donation</c>s, <c>People</c>, <c>Fund</c>s, etc.
/// </summary>
[JsonApiName("organization")]
public record Organization
{
  /// <summary>
  /// The unique identifier for an organization.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// The name for an organization.
  /// </summary>
  [JsonApiName("name")]
  public string? Name { get; init; }

  /// <summary>
  /// The time zone for an organization.
  /// </summary>
  [JsonApiName("time_zone")]
  public string? TimeZone { get; init; }

  /// <summary>
  /// <c>true</c> if this organization is accepting Text2Give donations, <c>false</c> otherwise.
  /// </summary>
  [JsonApiName("text2give_enabled")]
  public bool? Text2giveEnabled { get; init; }

}
