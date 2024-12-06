namespace Crews.PlanningCenter.Models.Services.V2018_08_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.SignupSheet" />.
/// </summary>
public enum SignupSheetIncludable
{
  /// <summary>
  /// include associated scheduled_people
  /// </summary>
  [JsonApiName("scheduled_people")]
  ScheduledPeople,

  /// <summary>
  /// include associated signup_sheet_metadata
  /// </summary>
  [JsonApiName("signup_sheet_metadata")]
  SignupSheetMetadata,

}

