using System.Text.Json;

namespace Crews.PlanningCenter.Models.Calendar.V2018_08_01.Entities;

/// <summary>
/// An organizational tag that can be applied to events.
/// 
/// Applied tags can be used to filter events on the calendar or
/// filter events for reports, iCal feeds, kiosk, and the widget.
/// </summary>
public record Tag
{
  /// <summary>
  /// Unique identifier for the tag
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// <c>true</c> indicates that this tag is used as a category on Church Center
  /// </summary>
  public bool? ChurchCenterCategory { get; init; }

  /// <summary>
  /// Hex color code of the tag
  /// </summary>
  public string? Color { get; init; }

  /// <summary>
  /// UTC time at which the tag was created
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// The tag name
  /// </summary>
  public string? Name { get; init; }

  /// <summary>
  /// If the tag belongs to a TagGroup,
  /// position indicates place in list within TagGroup in the UI.
  /// 
  /// If the tag does not belong to a TagGroup,
  /// position indicates place in list under "Individual Tags" in the UI.
  /// </summary>
  public double? Position { get; init; }

  /// <summary>
  /// UTC time at which the tag was updated
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

}
