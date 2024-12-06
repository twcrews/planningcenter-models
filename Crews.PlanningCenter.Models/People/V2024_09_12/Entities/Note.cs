using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2024_09_12.Entities;

/// <summary>
/// A note is text with a category connected to a person’s profile.
/// </summary>
[JsonApiName("note")]
public record Note
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  /// <remarks>
  /// The true name of this attribute is <c>note</c>.
  /// It has been changed here to avoid conflicts with the resource name.
  /// </remarks>
  [JsonApiName("note")]
  public string? NoteAttribute { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("created_at")]
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("updated_at")]
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("display_date")]
  public DateTime? DisplayDate { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("note_category_id")]
  public string? NoteCategoryId { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("organization_id")]
  public string? OrganizationId { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("person_id")]
  public string? PersonId { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("created_by_id")]
  public string? CreatedById { get; init; }

}
