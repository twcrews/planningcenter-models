namespace Crews.PlanningCenter.Models.People.V2022_01_05.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.MessageGroup" />.
/// </summary>
public enum MessageGroupIncludable
{
  /// <summary>
  /// include associated app
  /// </summary>
  App,

  /// <summary>
  /// include associated from
  /// </summary>
  From,

  /// <summary>
  /// include associated messages
  /// </summary>
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
  ContainsUserGeneratedContent,

  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-from_address) to reverse the order
  /// </summary>
  FromAddress,

  /// <summary>
  /// prefix with a hyphen (-message_count) to reverse the order
  /// </summary>
  MessageCount,

  /// <summary>
  /// prefix with a hyphen (-message_type) to reverse the order
  /// </summary>
  MessageType,

  /// <summary>
  /// prefix with a hyphen (-subject) to reverse the order
  /// </summary>
  Subject,

  /// <summary>
  /// prefix with a hyphen (-system_message) to reverse the order
  /// </summary>
  SystemMessage,

  /// <summary>
  /// prefix with a hyphen (-transactional_message) to reverse the order
  /// </summary>
  TransactionalMessage,

  /// <summary>
  /// prefix with a hyphen (-uuid) to reverse the order
  /// </summary>
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
  ContainsUserGeneratedContent,

  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  CreatedAt,

  /// <summary>
  /// Query on a specific from_address
  /// </summary>
  FromAddress,

  /// <summary>
  /// Query on a specific message_count
  /// </summary>
  MessageCount,

  /// <summary>
  /// Query on a specific message_type
  /// </summary>
  MessageType,

  /// <summary>
  /// Query on a specific subject
  /// </summary>
  Subject,

  /// <summary>
  /// Query on a specific system_message
  /// </summary>
  SystemMessage,

  /// <summary>
  /// Query on a specific transactional_message
  /// </summary>
  TransactionalMessage,

  /// <summary>
  /// Query on a specific uuid
  /// </summary>
  Uuid,

}

