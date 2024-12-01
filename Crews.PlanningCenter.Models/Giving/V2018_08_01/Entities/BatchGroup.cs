using System.Text.Json;

namespace Crews.PlanningCenter.Models.Giving.V2018_08_01.Entities;

/// <summary>
/// A `BatchGroup` is a collection of `Batch`es.
/// 
/// `BatchGroup`s are an optional way of organizing your `Batch`es into groups that share common characteristics. These are completely customizable and can be used in whatever way makes sense to your organization's workflow.
/// 
/// Similarly to `Batch`es, you can `commit` (see more in the Actions section) a `BatchGroup`, and by doing so, all `Batches` and `Donations` contained in the `BatchGroup` will also be committed.
/// 
/// </summary>
public record BatchGroup
{
  /// <summary>
  /// The unique identifier for a batch group. For batches and batch groups, these identifiers are unique not across all of Planning Center, but only per organization. As such, it is possible to see the same batch group `id` in multiple organizations.
  /// </summary>
  public string? Id { get; init; }

  /// <summary>
  /// The date and time at which a batch group was created. Example: `2000-01-01T12:00:00Z`
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// The date and time at which a batch group was last updated. Example: `2000-01-01T12:00:00Z`
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// A brief description of what a batch group is for. This is displayed in Giving to help differentiate different batch groups from one another. If no description is provided for a batch group, it will be referred to as `Untitled group` within Giving.
  /// </summary>
  public string? Description { get; init; }

  /// <summary>
  /// Returns `true` if a batch group has been committed, and `false` if it hasn't.
  /// </summary>
  public bool? Committed { get; init; }

  /// <summary>
  /// The gross total of cents donated within the batch group. Factors in all donations made to each batch within the group.
  /// </summary>
  public int? TotalCents { get; init; }

  /// <summary>
  /// The currency used to calculate `total_cents`.
  /// </summary>
  public string? TotalCurrency { get; init; }

  /// <summary>
  /// One of `in_progress`, `updating`, or `committed`. The `updating` state is temporary and describes a BatchGroup that is currently being changed in some way (e.g. moving from `in_progress` to `committed`). Certain changes to BatchGroups in this state (or their Batches or Donations) will be restricted until the BatchGroup has finished updating.
  /// </summary>
  public string? Status { get; init; }

}
