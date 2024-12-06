namespace Crews.PlanningCenter.Models.Services.V2018_11_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Live" />.
/// </summary>
public enum LiveIncludable
{
  /// <summary>
  /// include associated controller
  /// </summary>
  [JsonApiName("controller")]
  Controller,

  /// <summary>
  /// include associated current_item_time
  /// </summary>
  [JsonApiName("current_item_time")]
  CurrentItemTime,

  /// <summary>
  /// include associated items
  /// </summary>
  [JsonApiName("items")]
  Items,

  /// <summary>
  /// include associated next_item_time
  /// </summary>
  [JsonApiName("next_item_time")]
  NextItemTime,

  /// <summary>
  /// include associated service_type
  /// </summary>
  [JsonApiName("service_type")]
  ServiceType,

}

