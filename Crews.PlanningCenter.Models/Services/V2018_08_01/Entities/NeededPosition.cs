namespace Crews.PlanningCenter.Models.Services.V2018_08_01.Entities;

/// <summary>
/// An amount of unfilled positions needed within a team in a plan.
/// </summary>
public record NeededPosition
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public int? Quantity { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? TeamPositionName { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? ScheduledTo { get; init; }

}
