using System.Text.Json;

namespace Crews.PlanningCenter.Models.Services.V2018_11_01.Entities;

/// <summary>
/// A Service Type is a container for plans.
/// </summary>
[JsonApiName("service_type")]
public record ServiceType
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("archived_at")]
  public DateTime? ArchivedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("created_at")]
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("deleted_at")]
  public DateTime? DeletedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("name")]
  public string? Name { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("sequence")]
  public int? Sequence { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("updated_at")]
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("permissions")]
  public string? Permissions { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("attachment_types_enabled")]
  public bool? AttachmentTypesEnabled { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("scheduled_publish")]
  public bool? ScheduledPublish { get; init; }

  /// <summary>
  /// A array of hashes that maps an item title substring matcher to a color:
  /// 
  /// [{ name: "Announcements", color: "#FFFFFF" }]
  /// 
  /// Valid substring matchers are any string that could be used as an item title.
  /// 
  /// A color is the hexadecimal value of a valid color e.g. #FFFFFF
  /// Valid colors values are #e8f6df, #e0f7ff, #e6e2fd, #ffe0e8, #ffedd1, #cfcfcf, #eaebeb, and #ffffff
  /// </summary>
  [JsonApiName("custom_item_types")]
  public IEnumerable<JsonElement>? CustomItemTypes { get; init; }

  /// <summary>
  /// An array of hashes that maps an item type to a color:
  /// 
  /// [{ name: "Header", color: "#FFFFFF" }]
  /// 
  /// Valid names are Header, Song, and Media.
  /// 
  /// A color is the hexadecimal value of a valid color e.g. #FFFFFF
  /// Valid colors values are #e8f6df, #e0f7ff, #e6e2fd, #ffe0e8, #ffedd1, #cfcfcf, #eaebeb, and #ffffff
  /// </summary>
  [JsonApiName("standard_item_types")]
  public IEnumerable<JsonElement>? StandardItemTypes { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("background_check_permissions")]
  public string? BackgroundCheckPermissions { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("comment_permissions")]
  public string? CommentPermissions { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("frequency")]
  public string? Frequency { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("last_plan_from")]
  public string? LastPlanFrom { get; init; }

}
