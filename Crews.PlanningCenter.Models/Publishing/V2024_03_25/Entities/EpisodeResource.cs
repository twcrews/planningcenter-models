using System.Text.Json;

namespace Crews.PlanningCenter.Models.Publishing.V2024_03_25.Entities;

/// <summary>
/// Planning Center does not provide a description for this resource.
/// </summary>
[JsonApiName("episode_resource")]
public record EpisodeResource
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("featured")]
  public bool? Featured { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("icon")]
  public string? Icon { get; init; }

  /// <summary>
  /// Possible values: <c>giving_fund</c>, <c>people_form</c>, <c>generic_url</c>, <c>services_public_page</c>
  /// </summary>
  [JsonApiName("kind")]
  public string? Kind { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("position")]
  public int? Position { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("title")]
  public string? Title { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("type")]
  public string? Type { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("url")]
  public string? Url { get; init; }

}
