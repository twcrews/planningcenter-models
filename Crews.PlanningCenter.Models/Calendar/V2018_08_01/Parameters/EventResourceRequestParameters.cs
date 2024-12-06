namespace Crews.PlanningCenter.Models.Calendar.V2018_08_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.EventResourceRequest" />.
/// </summary>
public enum EventResourceRequestIncludable
{
  /// <summary>
  /// include associated created_by
  /// </summary>
  [JsonApiName("created_by")]
  CreatedBy,

  /// <summary>
  /// include associated event
  /// </summary>
  [JsonApiName("event")]
  Event,

  /// <summary>
  /// include associated resource
  /// </summary>
  [JsonApiName("resource")]
  Resource,

  /// <summary>
  /// include associated room_setup
  /// </summary>
  [JsonApiName("room_setup")]
  RoomSetup,

  /// <summary>
  /// include associated updated_by
  /// </summary>
  [JsonApiName("updated_by")]
  UpdatedBy,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.EventResourceRequest" />.
/// </summary>
public enum EventResourceRequestQueryable
{
  /// <summary>
  /// Query on a specific approval_sent
  /// </summary>
  [JsonApiName("approval_sent")]
  ApprovalSent,

  /// <summary>
  /// Query on a specific approval_status
  /// </summary>
  [JsonApiName("approval_status")]
  ApprovalStatus,

  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

}

