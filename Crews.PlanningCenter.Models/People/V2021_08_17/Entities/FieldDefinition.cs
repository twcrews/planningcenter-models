using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2021_08_17.Entities;

/// <summary>
/// A field definition represents a custom field -- its name, data type, etc.
/// </summary>
[JsonApiName("field_definition")]
public record FieldDefinition
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("data_type")]
  public string? DataType { get; init; }

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
  [JsonApiName("slug")]
  public string? Slug { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("config")]
  public string? Config { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("deleted_at")]
  public DateTime? DeletedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("tab_id")]
  public string? TabId { get; init; }

}
