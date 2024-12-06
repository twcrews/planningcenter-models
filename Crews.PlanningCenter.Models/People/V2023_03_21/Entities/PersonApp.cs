using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2023_03_21.Entities;

/// <summary>
/// A Person App is the relationship between a Person and an App.
/// </summary>
[JsonApiName("person_app")]
public record PersonApp
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("allow_pco_login")]
  public bool? AllowPcoLogin { get; init; }

  /// <summary>
  /// Possible values: <c>no_access</c>, <c>viewer</c>, or <c>editor</c>
  /// </summary>
  [JsonApiName("people_permissions")]
  public string? PeoplePermissions { get; init; }

}
