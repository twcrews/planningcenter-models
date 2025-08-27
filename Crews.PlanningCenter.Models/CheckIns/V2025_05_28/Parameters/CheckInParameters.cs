namespace Crews.PlanningCenter.Models.CheckIns.V2025_05_28.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.CheckIn" />.
/// </summary>
public enum CheckInIncludable
{
  /// <summary>
  /// include associated check_in_times
  /// </summary>
  [JsonApiName("check_in_times")]
  CheckInTimes,

  /// <summary>
  /// include associated checked_in_at
  /// </summary>
  [JsonApiName("checked_in_at")]
  CheckedInAt,

  /// <summary>
  /// include associated checked_in_by
  /// </summary>
  [JsonApiName("checked_in_by")]
  CheckedInBy,

  /// <summary>
  /// include associated checked_out_by
  /// </summary>
  [JsonApiName("checked_out_by")]
  CheckedOutBy,

  /// <summary>
  /// include associated event
  /// </summary>
  [JsonApiName("event")]
  Event,

  /// <summary>
  /// include associated event_period
  /// </summary>
  [JsonApiName("event_period")]
  EventPeriod,

  /// <summary>
  /// include associated event_times
  /// </summary>
  [JsonApiName("event_times")]
  EventTimes,

  /// <summary>
  /// include associated locations
  /// </summary>
  [JsonApiName("locations")]
  Locations,

  /// <summary>
  /// include associated options
  /// </summary>
  [JsonApiName("options")]
  Options,

  /// <summary>
  /// include associated person
  /// </summary>
  [JsonApiName("person")]
  Person,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.CheckIn" />.
/// </summary>
public enum CheckInOrderable
{
  /// <summary>
  /// prefix with a hyphen (-checked_out_at) to reverse the order
  /// </summary>
  [JsonApiName("checked_out_at")]
  CheckedOutAt,

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
  /// prefix with a hyphen (-last_name) to reverse the order
  /// </summary>
  [JsonApiName("last_name")]
  LastName,

  /// <summary>
  /// prefix with a hyphen (-number) to reverse the order
  /// </summary>
  [JsonApiName("number")]
  Number,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.CheckIn" />.
/// </summary>
public enum CheckInQueryable
{
  /// <summary>
  /// Query on a related person
  /// </summary>
  [JsonApiName("account_center_person_id")]
  AccountCenterPersonId,

  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// Query on a specific security_code
  /// </summary>
  [JsonApiName("security_code")]
  SecurityCode,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

}

/// <summary>
/// Filterable attributes for <see cref="Entities.CheckIn" />.
/// </summary>
public enum CheckInFilterable
{
  /// <summary>
  /// Filter by attendee.
  /// </summary>
  [JsonApiName("attendee")]
  Attendee,

  /// <summary>
  /// Filter by checked_out.
  /// </summary>
  [JsonApiName("checked_out")]
  CheckedOut,

  /// <summary>
  /// Filter by first_time.
  /// </summary>
  [JsonApiName("first_time")]
  FirstTime,

  /// <summary>
  /// Filter by guest.
  /// </summary>
  [JsonApiName("guest")]
  Guest,

  /// <summary>
  /// Filter by not_checked_out.
  /// </summary>
  [JsonApiName("not_checked_out")]
  NotCheckedOut,

  /// <summary>
  /// Filter by not_one_time_guest.
  /// </summary>
  [JsonApiName("not_one_time_guest")]
  NotOneTimeGuest,

  /// <summary>
  /// Filter by one_time_guest.
  /// </summary>
  [JsonApiName("one_time_guest")]
  OneTimeGuest,

  /// <summary>
  /// Filter by regular.
  /// </summary>
  [JsonApiName("regular")]
  Regular,

  /// <summary>
  /// Filter by volunteer.
  /// </summary>
  [JsonApiName("volunteer")]
  Volunteer,

}

