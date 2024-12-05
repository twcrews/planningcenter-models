namespace Crews.PlanningCenter.Models.Services.V2018_08_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.TeamPosition" />.
/// </summary>
public enum TeamPositionIncludable
{
  /// <summary>
  /// include associated tags
  /// </summary>
  Tags,

  /// <summary>
  /// include associated team
  /// </summary>
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
  Name,

}

