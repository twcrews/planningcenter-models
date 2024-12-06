using System.Text.Json;

namespace Crews.PlanningCenter.Models.Giving.V2018_08_01.Entities;

/// <summary>
/// A <c>Batch</c> is a collection of <c>Donation</c>s. When creating <c>Donation</c>'s via the API, you're required to put them in a <c>Batch</c>.
/// 
/// When a <c>Batch</c> is first created, it's in the <c>in_progress</c> or "uncommitted" state. You can freely add/remove/modify <c>Donation</c>s in this <c>Batch</c> and they won't show up in a donor's donation history online, they won't appear in any donor statements issued by the Giving admin, and changes to these donations are not flagged in the system log. Think of it as a staging area for donations.
/// 
/// When a <c>Batch</c> is committed (see more in the Actions section), all of the <c>Donation</c>s within it are also marked as "committed". At that point, they're visible to donors in their online history, and any further edits made to those <c>Donation</c>s are logged and visible to Giving admins.
/// 
/// With all of that in mind, you can use <c>Batch</c>es in one of two ways:
/// 
/// 1.  Create an uncommitted <c>Batch</c>, add <c>Donation</c>s to it, then commit the <c>Batch</c>.
/// 2.  Create a <c>Batch</c> with a least one donation, commit it, then add more <c>Donation</c>s to it.
/// 
/// In both cases, the end result is the same. The main difference is that option #2 does not provide you/other admins the opportunity to fix any mistakes before changes are logged and <c>Donation</c>s are made visible to donors. Any <c>Donation</c>s added to a committed <c>Batch</c> will automatically be committed as well. Note, batches can't be committed until they have at least one donation.
/// 
/// Whichever route you decide to take, it's helpful to make use of the <c>Batch</c>'s description to help differentiate these groupings from each other and from other <c>Batch</c>es that the Giving admins might be creating on their own.
/// </summary>
[JsonApiName("batch")]
public record Batch
{
  /// <summary>
  /// The unique identifier for a batch. For batches and batch groups, these identifiers are unique not across all of Planning Center, but only per organization. As such, it is possible to see the same batch <c>id</c> in multiple organizations.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// The date and time at which a batch was created. Example: <c>2000-01-01T12:00:00Z</c>
  /// </summary>
  [JsonApiName("created_at")]
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// The date and time at which a batch was last updated. Example: <c>2000-01-01T12:00:00Z</c>
  /// </summary>
  [JsonApiName("updated_at")]
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// The date and time that a batch was committed at. If it's <c>null</c>, the batch is still in progress or updating. Example: <c>2000-01-01T12:00:00Z</c>
  /// </summary>
  [JsonApiName("committed_at")]
  public DateTime? CommittedAt { get; init; }

  /// <summary>
  /// A brief description of what a batch is for. This is displayed in Giving to help differentiate different batches from one another. If no description is provided for a batch, it will be referred to as <c>Untitled batch</c> within Giving.
  /// </summary>
  [JsonApiName("description")]
  public string? Description { get; init; }

  /// <summary>
  /// Only available when requested with the <c>?fields</c> param
  /// </summary>
  [JsonApiName("donations_count")]
  public int? DonationsCount { get; init; }

  /// <summary>
  /// The gross total of cents donated within the batch.
  /// </summary>
  [JsonApiName("total_cents")]
  public int? TotalCents { get; init; }

  /// <summary>
  /// The currency used to calculate <c>total_cents</c>.
  /// </summary>
  [JsonApiName("total_currency")]
  public string? TotalCurrency { get; init; }

  /// <summary>
  /// One of <c>in_progress</c>, <c>updating</c>, or <c>committed</c>. The <c>updating</c> state is temporary and describes a Batch that is currently being changed in some way (e.g. moving from <c>in_progress</c> to <c>committed</c>). Certain changes to Batches in this state (or their Donations) will be restricted until the Batch has finished updating.
  /// </summary>
  [JsonApiName("status")]
  public string? Status { get; init; }

}
