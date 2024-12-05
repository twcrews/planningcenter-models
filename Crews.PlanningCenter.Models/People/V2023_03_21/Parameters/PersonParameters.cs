namespace Crews.PlanningCenter.Models.People.V2023_03_21.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Person" />.
/// </summary>
public enum PersonIncludable
{
  /// <summary>
  /// include associated addresses
  /// </summary>
  Addresses,

  /// <summary>
  /// include associated emails
  /// </summary>
  Emails,

  /// <summary>
  /// include associated field_data
  /// </summary>
  FieldData,

  /// <summary>
  /// include associated households
  /// </summary>
  Households,

  /// <summary>
  /// include associated inactive_reason
  /// </summary>
  InactiveReason,

  /// <summary>
  /// include associated marital_status
  /// </summary>
  MaritalStatus,

  /// <summary>
  /// include associated name_prefix
  /// </summary>
  NamePrefix,

  /// <summary>
  /// include associated name_suffix
  /// </summary>
  NameSuffix,

  /// <summary>
  /// include associated organization
  /// </summary>
  Organization,

  /// <summary>
  /// include associated person_apps
  /// </summary>
  PersonApps,

  /// <summary>
  /// include associated phone_numbers
  /// </summary>
  PhoneNumbers,

  /// <summary>
  /// include associated platform_notifications
  /// </summary>
  PlatformNotifications,

  /// <summary>
  /// include associated primary_campus
  /// </summary>
  PrimaryCampus,

  /// <summary>
  /// include associated school
  /// </summary>
  School,

  /// <summary>
  /// include associated social_profiles
  /// </summary>
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
  AccountingAdministrator,

  /// <summary>
  /// prefix with a hyphen (-anniversary) to reverse the order
  /// </summary>
  Anniversary,

  /// <summary>
  /// prefix with a hyphen (-birthdate) to reverse the order
  /// </summary>
  Birthdate,

  /// <summary>
  /// prefix with a hyphen (-child) to reverse the order
  /// </summary>
  Child,

  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-first_name) to reverse the order
  /// </summary>
  FirstName,

  /// <summary>
  /// prefix with a hyphen (-gender) to reverse the order
  /// </summary>
  Gender,

  /// <summary>
  /// prefix with a hyphen (-given_name) to reverse the order
  /// </summary>
  GivenName,

  /// <summary>
  /// prefix with a hyphen (-grade) to reverse the order
  /// </summary>
  Grade,

  /// <summary>
  /// prefix with a hyphen (-graduation_year) to reverse the order
  /// </summary>
  GraduationYear,

  /// <summary>
  /// prefix with a hyphen (-inactivated_at) to reverse the order
  /// </summary>
  InactivatedAt,

  /// <summary>
  /// prefix with a hyphen (-last_name) to reverse the order
  /// </summary>
  LastName,

  /// <summary>
  /// prefix with a hyphen (-membership) to reverse the order
  /// </summary>
  Membership,

  /// <summary>
  /// prefix with a hyphen (-middle_name) to reverse the order
  /// </summary>
  MiddleName,

  /// <summary>
  /// prefix with a hyphen (-nickname) to reverse the order
  /// </summary>
  Nickname,

  /// <summary>
  /// prefix with a hyphen (-people_permissions) to reverse the order
  /// </summary>
  PeoplePermissions,

  /// <summary>
  /// prefix with a hyphen (-remote_id) to reverse the order
  /// </summary>
  RemoteId,

  /// <summary>
  /// prefix with a hyphen (-site_administrator) to reverse the order
  /// </summary>
  SiteAdministrator,

  /// <summary>
  /// prefix with a hyphen (-status) to reverse the order
  /// </summary>
  Status,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
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
  AccountingAdministrator,

  /// <summary>
  /// Query on a specific anniversary
  /// </summary>
  Anniversary,

  /// <summary>
  /// Query on a specific birthdate
  /// </summary>
  Birthdate,

  /// <summary>
  /// Query on a specific child
  /// </summary>
  Child,

  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  CreatedAt,

  /// <summary>
  /// Query on a specific first_name
  /// </summary>
  FirstName,

  /// <summary>
  /// Query on a specific gender
  /// </summary>
  Gender,

  /// <summary>
  /// Query on a specific given_name
  /// </summary>
  GivenName,

  /// <summary>
  /// Query on a specific grade
  /// </summary>
  Grade,

  /// <summary>
  /// Query on a specific graduation_year
  /// </summary>
  GraduationYear,

  /// <summary>
  /// Query on a specific id
  /// </summary>
  Id,

  /// <summary>
  /// Set to an ISO 8601 date or time to make the profile inactive. Set to "null" to reactivate the profile.
  /// </summary>
  InactivatedAt,

  /// <summary>
  /// Query on a specific last_name
  /// </summary>
  LastName,

  /// <summary>
  /// Query on a specific medical_notes
  /// </summary>
  MedicalNotes,

  /// <summary>
  /// Query on a specific membership
  /// </summary>
  Membership,

  /// <summary>
  /// Set to "true" or "false" to filter. Can only be viewed and queried by an Organization Administrator.
  /// </summary>
  MfaConfigured,

  /// <summary>
  /// Query on a specific middle_name
  /// </summary>
  MiddleName,

  /// <summary>
  /// Query on a specific nickname
  /// </summary>
  Nickname,

  /// <summary>
  /// Query on a specific people_permissions
  /// </summary>
  PeoplePermissions,

  /// <summary>
  /// Query on a specific remote_id
  /// </summary>
  RemoteId,

  /// <summary>
  /// Search by Name (first, last, combination)
  /// </summary>
  SearchName,

  /// <summary>
  /// Search by Name (first, last, combination) or Email
  /// </summary>
  SearchNameOrEmail,

  /// <summary>
  /// Search by Name (first, last, combination), Email, or Phone Number
  /// </summary>
  SearchNameOrEmailOrPhoneNumber,

  /// <summary>
  /// Search by Phone Number
  /// </summary>
  SearchPhoneNumber,

  /// <summary>
  /// Search by Phone Number E164
  /// </summary>
  SearchPhoneNumberE164,

  /// <summary>
  /// Query on a specific site_administrator
  /// </summary>
  SiteAdministrator,

  /// <summary>
  /// Set to "inactive" to set "inactivated_at" to the current time and make the profile inactive. Set to anything else to clear "inactivated_at" and reactivate the profile.
  /// </summary>
  Status,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
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
  Admins,

  /// <summary>
  /// Filter by created_since.
  /// </summary>
  CreatedSince,

  /// <summary>
  /// Filter by organization_admins.
  /// </summary>
  OrganizationAdmins,

}

