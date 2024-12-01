using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2022_01_28.Entities;

/// <summary>
/// A note category share defines who can view notes in a category.
/// </summary>
public record NoteCategoryShare
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// Possible values: `No Access`, `Viewer`, `Editor`, or `Manager`
  /// </summary>
  public string? Group { get; init; }

  /// <summary>
  /// Possible values: `view` or `view_create`
  /// </summary>
  public string? Permission { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? PersonId { get; init; }

}
