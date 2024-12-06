namespace Crews.PlanningCenter.Models.Giving.V2019_10_18.Parameters;

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

