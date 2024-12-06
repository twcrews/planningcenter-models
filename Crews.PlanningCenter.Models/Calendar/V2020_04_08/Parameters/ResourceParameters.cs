namespace Crews.PlanningCenter.Models.Calendar.V2020_04_08.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Resource" />.
/// </summary>
public enum ResourceIncludable
{
  /// <summary>
  /// include associated resource_approval_groups
  /// </summary>
  [JsonApiName("resource_approval_groups")]
  ResourceApprovalGroups,

  /// <summary>
  /// include associated resource_folder
  /// </summary>
  [JsonApiName("resource_folder")]
  ResourceFolder,

  /// <summary>
  /// include associated resource_questions
  /// </summary>
  [JsonApiName("resource_questions")]
  ResourceQuestions,

  /// <summary>
  /// include associated room_setups
  /// </summary>
  [JsonApiName("room_setups")]
  RoomSetups,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.Resource" />.
/// </summary>
public enum ResourceOrderable
{
  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-expires_at) to reverse the order
  /// </summary>
  [JsonApiName("expires_at")]
  ExpiresAt,

  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
  [JsonApiName("name")]
  Name,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Resource" />.
/// </summary>
public enum ResourceQueryable
{
  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// Query on a specific kind
  /// </summary>
  [JsonApiName("kind")]
  Kind,

  /// <summary>
  /// Query on a specific name
  /// </summary>
  [JsonApiName("name")]
  Name,

  /// <summary>
  /// Query on a specific path_name
  /// </summary>
  [JsonApiName("path_name")]
  PathName,

  /// <summary>
  /// Query on a specific serial_number
  /// </summary>
  [JsonApiName("serial_number")]
  SerialNumber,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

}

/// <summary>
/// Filterable attributes for <see cref="Entities.Resource" />.
/// </summary>
public enum ResourceFilterable
{
  /// <summary>
  /// Filter by resources.
  /// </summary>
  [JsonApiName("resources")]
  Resources,

  /// <summary>
  /// Filter by rooms.
  /// </summary>
  [JsonApiName("rooms")]
  Rooms,

}

