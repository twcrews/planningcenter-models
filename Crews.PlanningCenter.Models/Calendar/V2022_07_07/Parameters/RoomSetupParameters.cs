namespace Crews.PlanningCenter.Models.Calendar.V2022_07_07.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.RoomSetup" />.
/// </summary>
public enum RoomSetupIncludable
{
  /// <summary>
  /// include associated containing_resource
  /// </summary>
  [JsonApiName("containing_resource")]
  ContainingResource,

  /// <summary>
  /// include associated resource_suggestions
  /// </summary>
  [JsonApiName("resource_suggestions")]
  ResourceSuggestions,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.RoomSetup" />.
/// </summary>
public enum RoomSetupOrderable
{
  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

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
/// Queryable attributes for <see cref="Entities.RoomSetup" />.
/// </summary>
public enum RoomSetupQueryable
{
  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// Query on a specific name
  /// </summary>
  [JsonApiName("name")]
  Name,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

}

/// <summary>
/// Filterable attributes for <see cref="Entities.RoomSetup" />.
/// </summary>
public enum RoomSetupFilterable
{
  /// <summary>
  /// Filter by shared_room_setups.
  /// </summary>
  [JsonApiName("shared_room_setups")]
  SharedRoomSetups,

}

