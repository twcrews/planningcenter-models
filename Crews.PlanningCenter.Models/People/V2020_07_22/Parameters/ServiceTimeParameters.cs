namespace Crews.PlanningCenter.Models.People.V2020_07_22.Parameters;

/// <summary>
/// Orderable attributes for <see cref="Entities.ServiceTime" />.
/// </summary>
public enum ServiceTimeOrderable
{
  /// <summary>
  /// prefix with a hyphen (-time) to reverse the order
  /// </summary>
  [JsonApiName("time")]
  Time,

}

