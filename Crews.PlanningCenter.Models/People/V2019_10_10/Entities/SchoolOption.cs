using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2019_10_10.Entities;

/// <summary>
/// A school option represents a school name, school type, grades, etc. and can be selected for a person.
/// </summary>
[JsonApiName("school_option")]
public record SchoolOption
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("value")]
  public string? Value { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("sequence")]
  public int? Sequence { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("beginning_grade")]
  public string? BeginningGrade { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("ending_grade")]
  public string? EndingGrade { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("school_types")]
  public IEnumerable<JsonElement>? SchoolTypes { get; init; }

}
