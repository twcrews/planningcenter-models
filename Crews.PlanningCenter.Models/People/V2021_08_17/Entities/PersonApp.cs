using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2021_08_17.Entities;

/// <summary>
/// A Person App is the relationship between a Person and an App.
/// </summary>
public record PersonApp
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public bool? AllowPcoLogin { get; init; }

  /// <summary>
  /// Possible values: <c>no_access</c>, <c>viewer</c>, or <c>editor</c>
  /// </summary>
  public string? PeoplePermissions { get; init; }

}
