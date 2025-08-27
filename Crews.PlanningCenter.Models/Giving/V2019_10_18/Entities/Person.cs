using System.Text.Json;

namespace Crews.PlanningCenter.Models.Giving.V2019_10_18.Entities;

/// <summary>
/// A Planning Center <c>Person</c> record that has been added to Giving.
/// 
/// The <c>Person</c> object in Planning Center is so crucial that we have an entire product dedicated to managing, keeping track of, editing, and creating these records and metadata around them. For additional info, take a look at the <a href="https://developer.planning.center/docs/#/apps/people">Planning Center People API Docs</a>.
/// </summary>
[JsonApiName("person")]
public record Person
{
  /// <summary>
  /// The unique identifier for a person.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// The level of Giving access granted to a person. See our product documentation for more information on <a href="https://pcogiving.zendesk.com/hc/en-us/articles/206541708-Permissions-in-Giving">permissions in Giving</a>.
  /// 
  /// Possible values: <c>administrator</c>, <c>reviewer</c>, <c>counter</c>, or <c>bookkeeper</c>
  /// </summary>
  [JsonApiName("permissions")]
  public string? Permissions { get; init; }

  /// <summary>
  /// An array of email addresses for a person. Can be managed via People. Example:
  /// ``<c>
  /// [
  /// {
  /// "address": "support@planningcenter.com",
  /// "location": "Home",
  /// "blocked": false,
  /// "primary": true
  /// }
  /// ]
  /// </c>``
  /// </summary>
  [JsonApiName("email_addresses")]
  public IEnumerable<JsonElement>? EmailAddresses { get; init; }

  /// <summary>
  /// An array of addresses for a person. Can be managed via People. Example:
  /// ``<c>
  /// [
  /// {
  /// "street_line_1": "2790 Gateway Rd",
  /// "street_line_2": "",
  /// "city": "Carlsbad",
  /// "state": "CA",
  /// "zip": "92009",
  /// "location": "Home",
  /// "primary": true,
  /// "street": "2790 Gateway Rd",
  /// "line_1": "2790 Gateway Rd",
  /// "line_2": "Carlsbad, CA 92009"
  /// }
  /// ]
  /// </c>``
  /// </summary>
  [JsonApiName("addresses")]
  public IEnumerable<JsonElement>? Addresses { get; init; }

  /// <summary>
  /// An array of phone numbers for a person. Can be managed via People. Example:
  /// ``<c>
  /// [
  /// {
  /// "number": "(123) 456-7890",
  /// "carrier": "PC Mobile",
  /// "location": "Mobile",
  /// "primary": true
  /// }
  /// ]
  /// </c>``
  /// </summary>
  [JsonApiName("phone_numbers")]
  public IEnumerable<JsonElement>? PhoneNumbers { get; init; }

  /// <summary>
  /// A person's first name.
  /// </summary>
  [JsonApiName("first_name")]
  public string? FirstName { get; init; }

  /// <summary>
  /// A person's last name.
  /// </summary>
  [JsonApiName("last_name")]
  public string? LastName { get; init; }

  /// <summary>
  /// The donor number for a person, if applicable. See our product documentation for more information on <a href="https://pcogiving.zendesk.com/hc/en-us/articles/360012298634-donor-numbers">donor numbers</a>.
  /// </summary>
  [JsonApiName("donor_number")]
  public int? DonorNumber { get; init; }

  /// <summary>
  /// Timestamp of a person's first donation or <c>null</c> if they have never donated.
  /// </summary>
  [JsonApiName("first_donated_at")]
  public DateTime? FirstDonatedAt { get; init; }

}
