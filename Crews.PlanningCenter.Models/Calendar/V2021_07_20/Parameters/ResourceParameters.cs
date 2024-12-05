namespace Crews.PlanningCenter.Models.Calendar.V2021_07_20.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Resource" />.
/// </summary>
public enum ResourceIncludable
{
  /// <summary>
  /// include associated resource_approval_groups
  /// </summary>
  ResourceApprovalGroups,

  /// <summary>
  /// include associated resource_folder
  /// </summary>
  ResourceFolder,

  /// <summary>
  /// include associated resource_questions
  /// </summary>
  ResourceQuestions,

  /// <summary>
  /// include associated room_setups
  /// </summary>
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
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-expires_at) to reverse the order
  /// </summary>
  ExpiresAt,

  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
  Name,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
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
  CreatedAt,

  /// <summary>
  /// Query on a specific kind
  /// </summary>
  Kind,

  /// <summary>
  /// Query on a specific name
  /// </summary>
  Name,

  /// <summary>
  /// Query on a specific path_name
  /// </summary>
  PathName,

  /// <summary>
  /// Query on a specific serial_number
  /// </summary>
  SerialNumber,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
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
  Resources,

  /// <summary>
  /// Filter by rooms.
  /// </summary>
  Rooms,

}

