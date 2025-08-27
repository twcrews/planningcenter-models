namespace Crews.PlanningCenter.Models.People.V2018_08_01.Parameters;

/// <summary>
/// Orderable attributes for <see cref="Entities.CustomSender" />.
/// </summary>
public enum CustomSenderOrderable
{
  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
  [JsonApiName("name")]
  Name,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

  /// <summary>
  /// prefix with a hyphen (-verification_requested_at) to reverse the order
  /// </summary>
  [JsonApiName("verification_requested_at")]
  VerificationRequestedAt,

  /// <summary>
  /// prefix with a hyphen (-verified_at) to reverse the order
  /// </summary>
  [JsonApiName("verified_at")]
  VerifiedAt,

}

