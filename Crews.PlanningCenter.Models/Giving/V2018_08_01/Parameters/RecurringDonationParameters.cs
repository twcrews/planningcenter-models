namespace Crews.PlanningCenter.Models.Giving.V2018_08_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.RecurringDonation" />.
/// </summary>
public enum RecurringDonationIncludable
{
  /// <summary>
  /// include associated designations
  /// </summary>
  [JsonApiName("designations")]
  Designations,

}

