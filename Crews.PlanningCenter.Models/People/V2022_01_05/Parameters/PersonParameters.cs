namespace Crews.PlanningCenter.Models.People.V2022_01_05.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Person" />.
/// </summary>
public enum PersonIncludable
{
  /// <summary>
  /// include associated addresses
  /// </summary>
  [JsonApiName("addresses")]
  Addresses,

  /// <summary>
  /// include associated emails
  /// </summary>
  [JsonApiName("emails")]
  Emails,

  /// <summary>
  /// include associated field_data
  /// </summary>
  [JsonApiName("field_data")]
  FieldData,

  /// <summary>
  /// include associated households
  /// </summary>
  [JsonApiName("households")]
  Households,

  /// <summary>
  /// include associated inactive_reason
  /// </summary>
  [JsonApiName("inactive_reason")]
  InactiveReason,

  /// <summary>
  /// include associated marital_status
  /// </summary>
  [JsonApiName("marital_status")]
  MaritalStatus,

  /// <summary>
  /// include associated name_prefix
  /// </summary>
  [JsonApiName("name_prefix")]
  NamePrefix,

  /// <summary>
  /// include associated name_suffix
  /// </summary>
  [JsonApiName("name_suffix")]
  NameSuffix,

  /// <summary>
  /// include associated organization
  /// </summary>
  [JsonApiName("organization")]
  Organization,

  /// <summary>
  /// include associated person_apps
  /// </summary>
  [JsonApiName("person_apps")]
  PersonApps,

  /// <summary>
  /// include associated phone_numbers
  /// </summary>
  [JsonApiName("phone_numbers")]
  PhoneNumbers,

  /// <summary>
  /// include associated platform_notifications
  /// </summary>
  [JsonApiName("platform_notifications")]
  PlatformNotifications,

  /// <summary>
  /// include associated primary_campus
  /// </summary>
  [JsonApiName("primary_campus")]
  PrimaryCampus,

  /// <summary>
  /// include associated school
  /// </summary>
  [JsonApiName("school")]
  School,

  /// <summary>
  /// include associated social_profiles
  /// </summary>
  [JsonApiName("social_profiles")]
  SocialProfiles,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.Person" />.
/// </summary>
public enum PersonOrderable
{
  /// <summary>
  /// prefix with a hyphen (-accounting_administrator) to reverse the order
  /// </summary>
  [JsonApiName("accounting_administrator")]
  AccountingAdministrator,

  /// <summary>
  /// prefix with a hyphen (-anniversary) to reverse the order
  /// </summary>
  [JsonApiName("anniversary")]
  Anniversary,

  /// <summary>
  /// prefix with a hyphen (-birthdate) to reverse the order
  /// </summary>
  [JsonApiName("birthdate")]
  Birthdate,

  /// <summary>
  /// prefix with a hyphen (-child) to reverse the order
  /// </summary>
  [JsonApiName("child")]
  Child,

  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-first_name) to reverse the order
  /// </summary>
  [JsonApiName("first_name")]
  FirstName,

  /// <summary>
  /// prefix with a hyphen (-gender) to reverse the order
  /// </summary>
  [JsonApiName("gender")]
  Gender,

  /// <summary>
  /// prefix with a hyphen (-given_name) to reverse the order
  /// </summary>
  [JsonApiName("given_name")]
  GivenName,

  /// <summary>
  /// prefix with a hyphen (-grade) to reverse the order
  /// </summary>
  [JsonApiName("grade")]
  Grade,

  /// <summary>
  /// prefix with a hyphen (-graduation_year) to reverse the order
  /// </summary>
  [JsonApiName("graduation_year")]
  GraduationYear,

  /// <summary>
  /// prefix with a hyphen (-inactivated_at) to reverse the order
  /// </summary>
  [JsonApiName("inactivated_at")]
  InactivatedAt,

  /// <summary>
  /// prefix with a hyphen (-last_name) to reverse the order
  /// </summary>
  [JsonApiName("last_name")]
  LastName,

  /// <summary>
  /// prefix with a hyphen (-membership) to reverse the order
  /// </summary>
  [JsonApiName("membership")]
  Membership,

  /// <summary>
  /// prefix with a hyphen (-middle_name) to reverse the order
  /// </summary>
  [JsonApiName("middle_name")]
  MiddleName,

  /// <summary>
  /// prefix with a hyphen (-nickname) to reverse the order
  /// </summary>
  [JsonApiName("nickname")]
  Nickname,

  /// <summary>
  /// prefix with a hyphen (-people_permissions) to reverse the order
  /// </summary>
  [JsonApiName("people_permissions")]
  PeoplePermissions,

  /// <summary>
  /// prefix with a hyphen (-remote_id) to reverse the order
  /// </summary>
  [JsonApiName("remote_id")]
  RemoteId,

  /// <summary>
  /// prefix with a hyphen (-site_administrator) to reverse the order
  /// </summary>
  [JsonApiName("site_administrator")]
  SiteAdministrator,

  /// <summary>
  /// prefix with a hyphen (-status) to reverse the order
  /// </summary>
  [JsonApiName("status")]
  Status,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Person" />.
/// </summary>
public enum PersonQueryable
{
  /// <summary>
  /// Query on a specific accounting_administrator
  /// </summary>
  [JsonApiName("accounting_administrator")]
  AccountingAdministrator,

  /// <summary>
  /// Query on a specific anniversary
  /// </summary>
  [JsonApiName("anniversary")]
  Anniversary,

  /// <summary>
  /// Query on a specific birthdate
  /// </summary>
  [JsonApiName("birthdate")]
  Birthdate,

  /// <summary>
  /// Query on a specific child
  /// </summary>
  [JsonApiName("child")]
  Child,

  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// Query on a specific first_name
  /// </summary>
  [JsonApiName("first_name")]
  FirstName,

  /// <summary>
  /// Query on a specific gender
  /// </summary>
  [JsonApiName("gender")]
  Gender,

  /// <summary>
  /// Query on a specific given_name
  /// </summary>
  [JsonApiName("given_name")]
  GivenName,

  /// <summary>
  /// Query on a specific grade
  /// </summary>
  [JsonApiName("grade")]
  Grade,

  /// <summary>
  /// Query on a specific graduation_year
  /// </summary>
  [JsonApiName("graduation_year")]
  GraduationYear,

  /// <summary>
  /// Query on a specific id
  /// </summary>
  [JsonApiName("id")]
  Id,

  /// <summary>
  /// Set to an ISO 8601 date or time to make the profile inactive. Set to "null" to reactivate the profile.
  /// </summary>
  [JsonApiName("inactivated_at")]
  InactivatedAt,

  /// <summary>
  /// Query on a specific last_name
  /// </summary>
  [JsonApiName("last_name")]
  LastName,

  /// <summary>
  /// Query on a specific medical_notes
  /// </summary>
  [JsonApiName("medical_notes")]
  MedicalNotes,

  /// <summary>
  /// Query on a specific membership
  /// </summary>
  [JsonApiName("membership")]
  Membership,

  /// <summary>
  /// Set to "true" or "false" to filter. Can only be viewed and queried by an Organization Administrator.
  /// </summary>
  [JsonApiName("mfa_configured")]
  MfaConfigured,

  /// <summary>
  /// Query on a specific middle_name
  /// </summary>
  [JsonApiName("middle_name")]
  MiddleName,

  /// <summary>
  /// Query on a specific nickname
  /// </summary>
  [JsonApiName("nickname")]
  Nickname,

  /// <summary>
  /// Query on a specific people_permissions
  /// </summary>
  [JsonApiName("people_permissions")]
  PeoplePermissions,

  /// <summary>
  /// Query on a related primary_campus
  /// </summary>
  [JsonApiName("primary_campus_id")]
  PrimaryCampusId,

  /// <summary>
  /// Query on a specific remote_id
  /// </summary>
  [JsonApiName("remote_id")]
  RemoteId,

  /// <summary>
  /// Query on a specific search_name
  /// </summary>
  [JsonApiName("search_name")]
  SearchName,

  /// <summary>
  /// Query on a specific search_name_or_email
  /// </summary>
  [JsonApiName("search_name_or_email")]
  SearchNameOrEmail,

  /// <summary>
  /// Query on a specific search_name_or_email_or_phone_number
  /// </summary>
  [JsonApiName("search_name_or_email_or_phone_number")]
  SearchNameOrEmailOrPhoneNumber,

  /// <summary>
  /// Query on a specific search_phone_number
  /// </summary>
  [JsonApiName("search_phone_number")]
  SearchPhoneNumber,

  /// <summary>
  /// Query on a specific search_phone_number_e164
  /// </summary>
  [JsonApiName("search_phone_number_e164")]
  SearchPhoneNumberE164,

  /// <summary>
  /// Query on a specific site_administrator
  /// </summary>
  [JsonApiName("site_administrator")]
  SiteAdministrator,

  /// <summary>
  /// Set to "inactive" to set "inactivated_at" to the current time and make the profile inactive. Set to anything else to clear "inactivated_at" and reactivate the profile.
  /// </summary>
  [JsonApiName("status")]
  Status,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

}

/// <summary>
/// Filterable attributes for <see cref="Entities.Person" />.
/// </summary>
public enum PersonFilterable
{
  /// <summary>
  /// Filter by admins.
  /// </summary>
  [JsonApiName("admins")]
  Admins,

  /// <summary>
  /// Filter by created_since.
  /// </summary>
  [JsonApiName("created_since")]
  CreatedSince,

  /// <summary>
  /// Filter by organization_admins.
  /// </summary>
  [JsonApiName("organization_admins")]
  OrganizationAdmins,

}

