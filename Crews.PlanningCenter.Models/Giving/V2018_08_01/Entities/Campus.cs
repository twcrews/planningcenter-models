using System.Text.Json;

namespace Crews.PlanningCenter.Models.Giving.V2018_08_01.Entities;

/// <summary>
/// A <c>Campus</c> that has been added to your <c>Organization</c>.
/// 
/// <c>Campus</c>es can be especially useful in filtering <c>Donation</c>s across the various locations of your <c>Organization</c>.
/// </summary>
[JsonApiName("campus")]
public record Campus
{
  /// <summary>
  /// The unique identifier for a campus.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// The name for a campus. Campus names can be set via Accounts or the People API.
  /// </summary>
  [JsonApiName("name")]
  public string? Name { get; init; }

  /// <summary>
  /// The address for a campus. Campus descriptions can be set via Accounts or the People API.
  /// </summary>
  [JsonApiName("address")]
  public JsonElement? Address { get; init; }

}
