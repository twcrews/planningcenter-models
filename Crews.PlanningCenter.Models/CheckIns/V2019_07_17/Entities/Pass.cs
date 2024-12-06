using System.Text.Json;

namespace Crews.PlanningCenter.Models.CheckIns.V2019_07_17.Entities;

/// <summary>
/// Enables quick lookup of a person via barcode reader.
/// </summary>
[JsonApiName("pass")]
public record Pass
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("code")]
  public string? Code { get; init; }

  /// <summary>
  /// Possible values: <c>barcode</c> or <c>pkpass</c>.
  /// 
  /// Using the <c>pkpass</c> value creates a mobile pass and sends an email to the associated person.
  /// </summary>
  [JsonApiName("kind")]
  public string? Kind { get; init; }

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

}
