using System.Text.Json;

namespace Crews.PlanningCenter.Models.Calendar.V2020_04_08.Entities;

/// <summary>
/// An answer to a question in a room or resource request.
/// </summary>
[JsonApiName("event_resource_answer")]
public record EventResourceAnswer
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// The answer formatted for display
  /// </summary>
  [JsonApiName("answer")]
  public JsonElement? Answer { get; init; }

  /// <summary>
  /// Only available when requested with the <c>?fields</c> param
  /// </summary>
  [JsonApiName("db_answer")]
  public string? DbAnswer { get; init; }

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

  /// <summary>
  /// Question details as of when it was answered
  /// </summary>
  [JsonApiName("question")]
  public JsonElement? Question { get; init; }

}
