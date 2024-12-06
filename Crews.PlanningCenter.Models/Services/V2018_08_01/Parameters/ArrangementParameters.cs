namespace Crews.PlanningCenter.Models.Services.V2018_08_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Arrangement" />.
/// </summary>
public enum ArrangementIncludable
{
  /// <summary>
  /// include associated keys
  /// </summary>
  [JsonApiName("keys")]
  Keys,

  /// <summary>
  /// include associated sections
  /// </summary>
  [JsonApiName("sections")]
  Sections,

}

