namespace Crews.PlanningCenter.Models.Services.V2018_11_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.TeamPosition" />.
/// </summary>
public enum TeamPositionIncludable
{
  /// <summary>
  /// include associated tags
  /// </summary>
  [JsonApiName("tags")]
  Tags,

  /// <summary>
  /// include associated team
  /// </summary>
  [JsonApiName("team")]
  Team,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.TeamPosition" />.
/// </summary>
public enum TeamPositionOrderable
{
  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
  [JsonApiName("name")]
  Name,

}

