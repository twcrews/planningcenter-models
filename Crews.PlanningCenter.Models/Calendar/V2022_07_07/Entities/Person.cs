using System.Text.Json;

namespace Crews.PlanningCenter.Models.Calendar.V2022_07_07.Entities;

/// <summary>
/// The people in your organization with access to Calendar.
/// </summary>
[JsonApiName("person")]
public record Person
{
  /// <summary>
  /// Unique identifier for the person
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// UTC time at which the person was created
  /// </summary>
  [JsonApiName("created_at")]
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// The person's first name
  /// </summary>
  [JsonApiName("first_name")]
  public string? FirstName { get; init; }

  /// <summary>
  /// The person's last name
  /// </summary>
  [JsonApiName("last_name")]
  public string? LastName { get; init; }

  /// <summary>
  /// The person's middle name
  /// </summary>
  [JsonApiName("middle_name")]
  public string? MiddleName { get; init; }

  /// <summary>
  /// UTC time at which the person was updated
  /// </summary>
  [JsonApiName("updated_at")]
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// Path to where the avatar image is stored
  /// </summary>
  [JsonApiName("avatar_url")]
  public string? AvatarUrl { get; init; }

  /// <summary>
  /// Indicates whether the person is a child
  /// </summary>
  [JsonApiName("child")]
  public bool? Child { get; init; }

  /// <summary>
  /// An object containing the person's contact data.
  /// 
  /// This can include an array of <c>email_addresses</c>, <c>addresses</c> and <c>phone_numbers</c>
  /// </summary>
  [JsonApiName("contact_data")]
  public string? ContactData { get; init; }

  /// <summary>
  /// <c>M</c> indicates male, <c>F</c> indicates female
  /// </summary>
  [JsonApiName("gender")]
  public string? Gender { get; init; }

  /// <summary>
  /// Indicates whether the person has access to Calendar
  /// </summary>
  [JsonApiName("has_access")]
  public bool? HasAccess { get; init; }

  /// <summary>
  /// Possible values:
  /// - <c>Mr.</c>
  /// - <c>Mrs.</c>
  /// - <c>Ms.</c>
  /// - <c>Miss</c>
  /// - <c>Dr.</c>
  /// - <c>Rev.</c>
  /// </summary>
  [JsonApiName("name_prefix")]
  public string? NamePrefix { get; init; }

  /// <summary>
  /// Possible values:
  /// - <c>Jr.</c>
  /// - <c>Sr.</c>
  /// - <c>Ph.D.</c>
  /// - <c>II</c>
  /// - <c>III</c>
  /// </summary>
  [JsonApiName("name_suffix")]
  public string? NameSuffix { get; init; }

  /// <summary>
  /// If the person is a member of an approval group, the number of EventResourceRequests needing resolution.
  /// 
  /// If <c>resolves_conflicts</c> is <c>true</c>, the count will also include the number of Conflicts needing resolution.
  /// </summary>
  [JsonApiName("pending_request_count")]
  public int? PendingRequestCount { get; init; }

  /// <summary>
  /// Integer that corresponds to the person's permissions in Calendar
  /// </summary>
  [JsonApiName("permissions")]
  public int? Permissions { get; init; }

  /// <summary>
  /// Indicates whether the person is able to resolve Conflicts
  /// </summary>
  [JsonApiName("resolves_conflicts")]
  public bool? ResolvesConflicts { get; init; }

  /// <summary>
  /// Indicates whether the person is a Organization Administrator
  /// </summary>
  [JsonApiName("site_administrator")]
  public bool? SiteAdministrator { get; init; }

  /// <summary>
  /// Possible values:
  /// - <c>active</c>: The person is marked "active" in People
  /// - <c>inactive</c>: The person is marked "inactive" in People
  /// 
  /// Possible values: <c>active</c>, <c>pending</c>, or <c>inactive</c>
  /// </summary>
  [JsonApiName("status")]
  public string? Status { get; init; }

  /// <summary>
  /// Indicates whether the person can edit other people
  /// </summary>
  [JsonApiName("can_edit_people")]
  public bool? CanEditPeople { get; init; }

  /// <summary>
  /// Indicates whether the person can edit resources
  /// </summary>
  [JsonApiName("can_edit_resources")]
  public bool? CanEditResources { get; init; }

  /// <summary>
  /// Indicates whether the person can edit rooms
  /// </summary>
  [JsonApiName("can_edit_rooms")]
  public bool? CanEditRooms { get; init; }

  /// <summary>
  /// Event permissions for the person
  /// </summary>
  [JsonApiName("event_permissions_type")]
  public string? EventPermissionsType { get; init; }

  /// <summary>
  /// Indicates whether the person is a member of at least one approval group
  /// 
  /// Only available when requested with the <c>?fields</c> param
  /// </summary>
  [JsonApiName("member_of_approval_groups")]
  public bool? MemberOfApprovalGroups { get; init; }

  /// <summary>
  /// The person's first name, last name, and name suffix
  /// </summary>
  [JsonApiName("name")]
  public string? Name { get; init; }

  /// <summary>
  /// People permissions for the person
  /// </summary>
  [JsonApiName("people_permissions_type")]
  public string? PeoplePermissionsType { get; init; }

  /// <summary>
  /// Room permissions for the person
  /// </summary>
  [JsonApiName("room_permissions_type")]
  public string? RoomPermissionsType { get; init; }

  /// <summary>
  /// Resource permissions for the person
  /// </summary>
  [JsonApiName("resources_permissions_type")]
  public string? ResourcesPermissionsType { get; init; }

}
