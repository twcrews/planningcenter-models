using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2019_01_14.Entities;

/// <summary>
/// A Person App is the relationship between a Person and an App.
/// </summary>
public record PersonApp
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public bool? AllowPcoLogin { get; init; }

  /// <summary>
  /// Possible values: `no_access`, `viewer`, or `editor`
  /// </summary>
  public string? PeoplePermissions { get; init; }

}
