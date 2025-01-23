using System.Text.Json;

namespace Crews.PlanningCenter.Models.Services.V2018_11_01.Entities;

/// <summary>
/// The root level of an organization where account-level settings are applied.
/// </summary>
[JsonApiName("organization")]
public record Organization
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("id")]
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("ccli")]
  public string? Ccli { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("created_at")]
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Two possible values, <c>US</c> <c>EU</c>
  /// </summary>
  [JsonApiName("date_format")]
  public string? DateFormat { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("music_stand_enabled")]
  public bool? MusicStandEnabled { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("name")]
  public string? Name { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("projector_enabled")]
  public bool? ProjectorEnabled { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("time_zone")]
  public string? TimeZone { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("twenty_four_hour_time")]
  public bool? TwentyFourHourTime { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("updated_at")]
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("owner_name")]
  public string? OwnerName { get; init; }

  /// <summary>
  /// Possible values: <c>editor</c>, <c>administrator</c>, <c>site_administrator</c>
  /// </summary>
  [JsonApiName("required_to_set_download_permission")]
  public string? RequiredToSetDownloadPermission { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("secret")]
  public string? Secret { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("allow_mp3_download")]
  public bool? AllowMp3Download { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("calendar_starts_on_sunday")]
  public bool? CalendarStartsOnSunday { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("ccli_connected")]
  public bool? CcliConnected { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("ccli_auto_reporting_enabled")]
  public bool? CcliAutoReportingEnabled { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("ccli_reporting_enabled")]
  public bool? CcliReportingEnabled { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("extra_file_storage_allowed")]
  public bool? ExtraFileStorageAllowed { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("file_storage_exceeded")]
  public bool? FileStorageExceeded { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("file_storage_size")]
  public bool? FileStorageSize { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("file_storage_size_used")]
  public bool? FileStorageSizeUsed { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("file_storage_extra_enabled")]
  public bool? FileStorageExtraEnabled { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("rehearsal_mix_enabled")]
  public bool? RehearsalMixEnabled { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("rehearsal_pack_connected")]
  public bool? RehearsalPackConnected { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("legacy_id")]
  public string? LegacyId { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("file_storage_extra_charges")]
  public int? FileStorageExtraCharges { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("people_allowed")]
  public int? PeopleAllowed { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("people_remaining")]
  public int? PeopleRemaining { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  [JsonApiName("beta")]
  public bool? Beta { get; init; }

}
