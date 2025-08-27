namespace Crews.PlanningCenter.Models.People.V2019_01_14.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.MessageGroup" />.
/// </summary>
public enum MessageGroupIncludable
{
  /// <summary>
  /// include associated app
  /// </summary>
  [JsonApiName("app")]
  App,

  /// <summary>
  /// include associated from
  /// </summary>
  [JsonApiName("from")]
  From,

  /// <summary>
  /// include associated messages
  /// </summary>
  [JsonApiName("messages")]
  Messages,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.MessageGroup" />.
/// </summary>
public enum MessageGroupOrderable
{
  /// <summary>
  /// prefix with a hyphen (-contains_user_generated_content) to reverse the order
  /// </summary>
  [JsonApiName("contains_user_generated_content")]
  ContainsUserGeneratedContent,

  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-from_address) to reverse the order
  /// </summary>
  [JsonApiName("from_address")]
  FromAddress,

  /// <summary>
  /// prefix with a hyphen (-message_count) to reverse the order
  /// </summary>
  [JsonApiName("message_count")]
  MessageCount,

  /// <summary>
  /// prefix with a hyphen (-message_type) to reverse the order
  /// </summary>
  [JsonApiName("message_type")]
  MessageType,

  /// <summary>
  /// prefix with a hyphen (-reply_to_address) to reverse the order
  /// </summary>
  [JsonApiName("reply_to_address")]
  ReplyToAddress,

  /// <summary>
  /// prefix with a hyphen (-reply_to_name) to reverse the order
  /// </summary>
  [JsonApiName("reply_to_name")]
  ReplyToName,

  /// <summary>
  /// prefix with a hyphen (-subject) to reverse the order
  /// </summary>
  [JsonApiName("subject")]
  Subject,

  /// <summary>
  /// prefix with a hyphen (-system_message) to reverse the order
  /// </summary>
  [JsonApiName("system_message")]
  SystemMessage,

  /// <summary>
  /// prefix with a hyphen (-transactional_message) to reverse the order
  /// </summary>
  [JsonApiName("transactional_message")]
  TransactionalMessage,

  /// <summary>
  /// prefix with a hyphen (-uuid) to reverse the order
  /// </summary>
  [JsonApiName("uuid")]
  Uuid,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.MessageGroup" />.
/// </summary>
public enum MessageGroupQueryable
{
  /// <summary>
  /// Query on a specific contains_user_generated_content
  /// </summary>
  [JsonApiName("contains_user_generated_content")]
  ContainsUserGeneratedContent,

  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// Query on a specific from_address
  /// </summary>
  [JsonApiName("from_address")]
  FromAddress,

  /// <summary>
  /// Query on a specific message_count
  /// </summary>
  [JsonApiName("message_count")]
  MessageCount,

  /// <summary>
  /// Query on a specific message_type
  /// </summary>
  [JsonApiName("message_type")]
  MessageType,

  /// <summary>
  /// Query on a specific reply_to_address
  /// </summary>
  [JsonApiName("reply_to_address")]
  ReplyToAddress,

  /// <summary>
  /// Query on a specific reply_to_name
  /// </summary>
  [JsonApiName("reply_to_name")]
  ReplyToName,

  /// <summary>
  /// Query on a specific subject
  /// </summary>
  [JsonApiName("subject")]
  Subject,

  /// <summary>
  /// Query on a specific system_message
  /// </summary>
  [JsonApiName("system_message")]
  SystemMessage,

  /// <summary>
  /// Query on a specific transactional_message
  /// </summary>
  [JsonApiName("transactional_message")]
  TransactionalMessage,

  /// <summary>
  /// Query on a specific uuid
  /// </summary>
  [JsonApiName("uuid")]
  Uuid,

}

