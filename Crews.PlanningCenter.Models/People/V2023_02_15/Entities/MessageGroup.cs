using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2023_02_15.Entities;

/// <summary>
/// A message group represents one or more emails or text messages sent from one of the Planning Center apps. The message group indicates the from person, app, etc.
/// </summary>
[JsonApiName("message_group")]
public record MessageGroup
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("uuid")]
  public string? Uuid { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("message_type")]
  public string? MessageType { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("from_address")]
  public string? FromAddress { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("subject")]
  public string? Subject { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("message_count")]
  public int? MessageCount { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("system_message")]
  public bool? SystemMessage { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("transactional_message")]
  public bool? TransactionalMessage { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("contains_user_generated_content")]
  public bool? ContainsUserGeneratedContent { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("created_at")]
  public DateTime? CreatedAt { get; init; }

}
