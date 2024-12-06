namespace Crews.PlanningCenter.Models.Publishing.V2018_08_01.Parameters;

/// <summary>
/// Orderable attributes for <see cref="Entities.Speaker" />.
/// </summary>
public enum SpeakerOrderable
{
  /// <summary>
  /// prefix with a hyphen (-first_name) to reverse the order
  /// </summary>
  [JsonApiName("first_name")]
  FirstName,

}

