namespace Crews.PlanningCenter.Models.Services.V2018_08_01.Entities;

/// <summary>
/// A plan item note that belongs to a category.
/// 
/// Note: You can only assign the category on create. If you want to change category; delete the current note, and create a new one passing in the <c>item_note_category_id</c> then.
/// </summary>
public record ItemNote
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Content { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? CategoryName { get; init; }

}
