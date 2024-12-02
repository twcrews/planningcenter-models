namespace Crews.PlanningCenter.Models.Giving.V2018_08_01.Entities;

/// <summary>
/// A <c>BatchGroup</c> is a collection of <c>Batch</c>es.
/// 
/// <c>BatchGroup</c>s are an optional way of organizing your <c>Batch</c>es into groups that share common characteristics. These are completely customizable and can be used in whatever way makes sense to your organization's workflow.
/// 
/// Similarly to <c>Batch</c>es, you can <c>commit</c> (see more in the Actions section) a <c>BatchGroup</c>, and by doing so, all <c>Batches</c> and <c>Donations</c> contained in the <c>BatchGroup</c> will also be committed.
/// </summary>
public record BatchGroup
{
  /// <summary>
  /// The unique identifier for a batch group. For batches and batch groups, these identifiers are unique not across all of Planning Center, but only per organization. As such, it is possible to see the same batch group <c>id</c> in multiple organizations.
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// The date and time at which a batch group was created. Example: <c>2000-01-01T12:00:00Z</c>
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// The date and time at which a batch group was last updated. Example: <c>2000-01-01T12:00:00Z</c>
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// A brief description of what a batch group is for. This is displayed in Giving to help differentiate different batch groups from one another. If no description is provided for a batch group, it will be referred to as <c>Untitled group</c> within Giving.
  /// </summary>
  public string? Description { get; init; }

  /// <summary>
  /// Returns <c>true</c> if a batch group has been committed, and <c>false</c> if it hasn't.
  /// </summary>
  public bool? Committed { get; init; }

  /// <summary>
  /// The gross total of cents donated within the batch group. Factors in all donations made to each batch within the group.
  /// </summary>
  public int? TotalCents { get; init; }

  /// <summary>
  /// The currency used to calculate <c>total_cents</c>.
  /// </summary>
  public string? TotalCurrency { get; init; }

  /// <summary>
  /// One of <c>in_progress</c>, <c>updating</c>, or <c>committed</c>. The <c>updating</c> state is temporary and describes a BatchGroup that is currently being changed in some way (e.g. moving from <c>in_progress</c> to <c>committed</c>). Certain changes to BatchGroups in this state (or their Batches or Donations) will be restricted until the BatchGroup has finished updating.
  /// </summary>
  public string? Status { get; init; }

}
