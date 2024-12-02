namespace Crews.PlanningCenter.Models.Groups.V2023_07_10.Entities;

/// <summary>
/// A file or link resource that can be shared with a group.
/// </summary>
public record Resource
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// The description of the resource written by the person who created it.
  /// </summary>
  public string? Description { get; init; }

  /// <summary>
  /// The date and time the resource was last updated.
  /// </summary>
  public DateTime? LastUpdated { get; init; }

  /// <summary>
  /// The name/title of the resource.
  /// </summary>
  public string? Name { get; init; }

  /// <summary>
  /// Either <c>FileResource</c> or <c>LinkResource</c>
  /// </summary>
  public string? Type { get; init; }

  /// <summary>
  /// Possible values: <c>leaders</c> or <c>members</c>
  /// </summary>
  public string? Visibility { get; init; }

}
