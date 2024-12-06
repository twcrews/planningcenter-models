namespace Crews.PlanningCenter.Models.People.V2020_07_22.Parameters;

/// <summary>
/// Orderable attributes for <see cref="Entities.Carrier" />.
/// </summary>
public enum CarrierOrderable
{
  /// <summary>
  /// prefix with a hyphen (-international) to reverse the order
  /// </summary>
  [JsonApiName("international")]
  International,

  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
  [JsonApiName("name")]
  Name,

}

