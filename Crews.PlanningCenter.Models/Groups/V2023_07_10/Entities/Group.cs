using System.Text.Json;

namespace Crews.PlanningCenter.Models.Groups.V2023_07_10.Entities;

/// <summary>
/// A group of people that meet together regularly.
/// </summary>
[JsonApiName("group")]
public record Group
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// The date and time the group was archived.
  /// </summary>
  [JsonApiName("archived_at")]
  public DateTime? ArchivedAt { get; init; }

  /// <summary>
  /// A boolean representing the current user's authorization to start a new conversation in the group.
  /// 
  /// Only available when requested with the <c>?fields</c> param
  /// </summary>
  [JsonApiName("can_create_conversation")]
  public bool? CanCreateConversation { get; init; }

  /// <summary>
  /// A boolean representing whether or not the group has Chat enabled.
  /// </summary>
  [JsonApiName("chat_enabled")]
  public bool? ChatEnabled { get; init; }

  /// <summary>
  /// If a contact_email is provided, we will display a contact button on the public page
  /// where potential members can ask questions before joining the group.
  /// </summary>
  [JsonApiName("contact_email")]
  public string? ContactEmail { get; init; }

  /// <summary>
  /// The date and time the group was created.
  /// </summary>
  [JsonApiName("created_at")]
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// A longform description of the group. Can contain HTML markup.
  /// </summary>
  [JsonApiName("description")]
  public string? Description { get; init; }

  /// <summary>
  /// The visibility of events for the group.
  /// 
  /// Possible values: <c>public</c> or <c>members</c>
  /// </summary>
  [JsonApiName("events_visibility")]
  public string? EventsVisibility { get; init; }

  /// <summary>
  /// A hash of header image URLs. The keys are <c>thumbnail</c>, <c>medium</c>, and <c>original</c>.
  /// 
  /// ``<c>json
  /// {
  /// "thumbnail": "https://groups-production.s3.amazonaws.com/uploads/group/header_image/1986065/thumbnail_image-1676676396838.jpg",
  /// "medium": "https://groups-production.s3.amazonaws.com/uploads/group/header_image/1986065/medium_image-1676676396838.jpg",
  /// "original": "https://groups-production.s3.amazonaws.com/uploads/group/header_image/1986065/image-1676676396838.jpg"
  /// }
  /// </c>``
  /// </summary>
  [JsonApiName("header_image")]
  public JsonElement? HeaderImage { get; init; }

  /// <summary>
  /// Whether or not group leaders have access to the entire
  /// church database on the admin side of Groups. (Not recommended)
  /// </summary>
  [JsonApiName("leaders_can_search_people_database")]
  public bool? LeadersCanSearchPeopleDatabase { get; init; }

  /// <summary>
  /// The location type preference for the group.
  /// 
  /// Possible values: <c>physical</c> or <c>virtual</c>
  /// </summary>
  [JsonApiName("location_type_preference")]
  public string? LocationTypePreference { get; init; }

  /// <summary>
  /// The number of members in the group, includes leaders.
  /// Does not include membership requests.
  /// </summary>
  [JsonApiName("memberships_count")]
  public int? MembershipsCount { get; init; }

  /// <summary>
  /// The name/title of the group.
  /// </summary>
  [JsonApiName("name")]
  public string? Name { get; init; }

  /// <summary>
  /// The public URL for the group on Church Center.
  /// </summary>
  [JsonApiName("public_church_center_web_url")]
  public string? PublicChurchCenterWebUrl { get; init; }

  /// <summary>
  /// A text summary of the group's typical meeting schedule.
  /// Can be a string like "Sundays at 9:30am" or "Every other Tuesday at 7pm".
  /// </summary>
  [JsonApiName("schedule")]
  public string? Schedule { get; init; }

  /// <summary>
  /// The URL for the group's virtual location. A zoom link, for example.
  /// This could be set even if <c>location_type_preference</c> is <c>physical</c>.
  /// This is useful if you want to display a zoom link even if the group is meeting in person.
  /// </summary>
  [JsonApiName("virtual_location_url")]
  public string? VirtualLocationUrl { get; init; }

  /// <summary>
  /// DEPRECATED: This is a private attribute used by Home widgets that we plan to remove soon.
  /// 
  /// Only available when requested with the <c>?fields</c> param
  /// </summary>
  [JsonApiName("widget_status")]
  public JsonElement? WidgetStatus { get; init; }

}
