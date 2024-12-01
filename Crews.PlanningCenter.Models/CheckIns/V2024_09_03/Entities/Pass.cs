using System.Text.Json;

namespace Crews.PlanningCenter.Models.CheckIns.V2024_09_03.Entities;

/// <summary>
/// Enables quick lookup of a person via barcode reader.
/// 
/// </summary>
public record Pass
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Code { get; init; }

  /// <summary>
  /// Possible values: `barcode` or `pkpass`.
  /// 
  /// Using the `pkpass` value creates a mobile pass and sends an email to the associated person.
  /// 
  /// </summary>
  public string? Kind { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

}