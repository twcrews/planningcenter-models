namespace Crews.PlanningCenter.Models.Services.V2018_11_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.AvailableSignup" />.
/// </summary>
public enum AvailableSignupIncludable
{
  /// <summary>
  /// include associated signup_sheets
  /// </summary>
  [JsonApiName("signup_sheets")]
  SignupSheets,

}

