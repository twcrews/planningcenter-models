namespace Crews.PlanningCenter.Models.Services.V2018_11_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Live" />.
/// </summary>
public enum LiveIncludable
{
  /// <summary>
  /// include associated controller
  /// </summary>
  Controller,

  /// <summary>
  /// include associated current_item_time
  /// </summary>
  CurrentItemTime,

  /// <summary>
  /// include associated items
  /// </summary>
  Items,

  /// <summary>
  /// include associated next_item_time
  /// </summary>
  NextItemTime,

  /// <summary>
  /// include associated service_type
  /// </summary>
  ServiceType,

}

