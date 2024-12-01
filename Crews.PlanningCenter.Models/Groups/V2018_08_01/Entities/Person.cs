using System.Text.Json;

namespace Crews.PlanningCenter.Models.Groups.V2018_08_01.Entities;

/// <summary>
/// A person is a user of Planning Center.
/// They can be a member of a group, a leader of a group, or an administrator.
/// 
/// </summary>
public record Person
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// Returns all the addresses associated with this person.
  /// 
  /// </summary>
  public IEnumerable<JsonElement>? Addresses { get; init; }

  /// <summary>
  /// The URL of the person's avatar.
  /// 
  /// </summary>
  public string? AvatarUrl { get; init; }

  /// <summary>
  /// Whether or not the person is under 13 years old.
  /// This is false if a birthdate is not set.
  /// 
  /// 
  /// Only available when requested with the `?fields` param
  /// </summary>
  public bool? Child { get; init; }

  /// <summary>
  /// Date and time this person was first created in Planning Center
  /// 
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Returns all the email addresses associated with this person.
  /// 
  /// ```json
  /// [{
  /// "address": "sam@example.com",
  /// "location": "Home",
  /// "primary": true
  /// }]
  /// ```
  /// 
  /// </summary>
  public IEnumerable<JsonElement>? EmailAddresses { get; init; }

  /// <summary>
  /// The person's first name.
  /// 
  /// </summary>
  public string? FirstName { get; init; }

  /// <summary>
  /// The person's last name.
  /// 
  /// </summary>
  public string? LastName { get; init; }

  /// <summary>
  /// Can be `administrator`, `group_type_manager`, `leader`, `member`, or `no access`.
  /// 
  /// </summary>
  public string? Permissions { get; init; }

  /// <summary>
  /// Returns all the phone numbers associated with this person.
  /// 
  /// ```json
  /// [{
  /// "number": "(800) 123-4567",
  /// "carrier": null,
  /// "location": "Mobile",
  /// "primary": true
  /// }]
  /// ```
  /// 
  /// </summary>
  public IEnumerable<JsonElement>? PhoneNumbers { get; init; }

}
