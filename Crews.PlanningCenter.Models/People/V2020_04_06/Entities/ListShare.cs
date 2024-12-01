using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2020_04_06.Entities;

/// <summary>
/// A list share indicates who has access to edit a list.
/// </summary>
public record ListShare
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// Possible values: `view` or `manage`
  /// </summary>
  public string? Permission { get; init; }

  /// <summary>
  /// Possible values: `No Access`, `Viewer`, `Editor`, or `Manager`
  /// </summary>
  public string? Group { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Name { get; init; }

}
