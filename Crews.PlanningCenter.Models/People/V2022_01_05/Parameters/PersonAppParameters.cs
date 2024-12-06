namespace Crews.PlanningCenter.Models.People.V2022_01_05.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.PersonApp" />.
/// </summary>
public enum PersonAppIncludable
{
  /// <summary>
  /// include associated app
  /// </summary>
  [JsonApiName("app")]
  App,

}
