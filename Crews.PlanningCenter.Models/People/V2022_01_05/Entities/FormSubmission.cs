using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2022_01_05.Entities;

/// <summary>
/// A form submission.
/// </summary>
[JsonApiName("form_submission")]
public record FormSubmission
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("verified")]
  public bool? Verified { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("created_at")]
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("requires_verification")]
  public bool? RequiresVerification { get; init; }

}
