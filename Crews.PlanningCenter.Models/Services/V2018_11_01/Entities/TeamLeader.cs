using System.Text.Json;

namespace Crews.PlanningCenter.Models.Services.V2018_11_01.Entities;

/// <summary>
/// A leader of a specific Team in a Service Type.
/// </summary>
[JsonApiName("team_leader")]
public record TeamLeader
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("send_responses_for_accepts")]
  public bool? SendResponsesForAccepts { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("send_responses_for_declines")]
  public bool? SendResponsesForDeclines { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("send_responses_for_blockouts")]
  public bool? SendResponsesForBlockouts { get; init; }

}
