namespace Crews.PlanningCenter.Models.Calendar.V2022_07_07.Entities;

/// <summary>
/// The people in your organization with access to Calendar.
/// </summary>
public record Person
{
  /// <summary>
  /// Unique identifier for the person
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// UTC time at which the person was created
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// The person's first name
  /// </summary>
  public string? FirstName { get; init; }

  /// <summary>
  /// The person's last name
  /// </summary>
  public string? LastName { get; init; }

  /// <summary>
  /// The person's middle name
  /// </summary>
  public string? MiddleName { get; init; }

  /// <summary>
  /// UTC time at which the person was updated
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// Path to where the avatar image is stored
  /// </summary>
  public string? AvatarUrl { get; init; }

  /// <summary>
  /// Indicates whether the person is a child
  /// </summary>
  public bool? Child { get; init; }

  /// <summary>
  /// An object containing the person's contact data.
  /// 
  /// This can include an array of <c>email_addresses</c>, <c>addresses</c> and <c>phone_numbers</c>
  /// </summary>
  public string? ContactData { get; init; }

  /// <summary>
  /// <c>M</c> indicates male, <c>F</c> indicates female
  /// </summary>
  public string? Gender { get; init; }

  /// <summary>
  /// Indicates whether the person has access to Calendar
  /// </summary>
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
  public string? NamePrefix { get; init; }

  /// <summary>
  /// Possible values:
  /// - <c>Jr.</c>
  /// - <c>Sr.</c>
  /// - <c>Ph.D.</c>
  /// - <c>II</c>
  /// - <c>III</c>
  /// </summary>
  public string? NameSuffix { get; init; }

  /// <summary>
  /// If the person is a member of an approval group, the number of EventResourceRequests needing resolution.
  /// 
  /// If <c>resolves_conflicts</c> is <c>true</c>, the count will also include the number of Conflicts needing resolution.
  /// </summary>
  public int? PendingRequestCount { get; init; }

  /// <summary>
  /// Integer that corresponds to the person's permissions in Calendar
  /// </summary>
  public int? Permissions { get; init; }

  /// <summary>
  /// Indicates whether the person is able to resolve Conflicts
  /// </summary>
  public bool? ResolvesConflicts { get; init; }

  /// <summary>
  /// Indicates whether the person is a Organization Administrator
  /// </summary>
  public bool? SiteAdministrator { get; init; }

  /// <summary>
  /// Possible values:
  /// - <c>active</c>: The person is marked "active" in People
  /// - <c>inactive</c>: The person is marked "inactive" in People
  /// 
  /// Possible values: <c>active</c>, <c>pending</c>, or <c>inactive</c>
  /// </summary>
  public string? Status { get; init; }

  /// <summary>
  /// Indicates whether the person can edit other people
  /// </summary>
  public bool? CanEditPeople { get; init; }

  /// <summary>
  /// Indicates whether the person can edit resources
  /// </summary>
  public bool? CanEditResources { get; init; }

  /// <summary>
  /// Indicates whether the person can edit rooms
  /// </summary>
  public bool? CanEditRooms { get; init; }

  /// <summary>
  /// Event permissions for the person
  /// </summary>
  public string? EventPermissionsType { get; init; }

  /// <summary>
  /// Indicates whether the person is a member of at least one approval group
  /// 
  /// Only available when requested with the <c>?fields</c> param
  /// </summary>
  public bool? MemberOfApprovalGroups { get; init; }

  /// <summary>
  /// The person's first name, last name, and name suffix
  /// </summary>
  public string? Name { get; init; }

  /// <summary>
  /// People permissions for the person
  /// </summary>
  public string? PeoplePermissionsType { get; init; }

  /// <summary>
  /// Room permissions for the person
  /// </summary>
  public string? RoomPermissionsType { get; init; }

  /// <summary>
  /// Resource permissions for the person
  /// </summary>
  public string? ResourcesPermissionsType { get; init; }

}
