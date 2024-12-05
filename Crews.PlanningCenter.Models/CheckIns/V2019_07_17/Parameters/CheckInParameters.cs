namespace Crews.PlanningCenter.Models.CheckIns.V2019_07_17.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.CheckIn" />.
/// </summary>
public enum CheckInIncludable
{
  /// <summary>
  /// include associated check_in_times
  /// </summary>
  CheckInTimes,

  /// <summary>
  /// include associated checked_in_at
  /// </summary>
  CheckedInAt,

  /// <summary>
  /// include associated checked_in_by
  /// </summary>
  CheckedInBy,

  /// <summary>
  /// include associated checked_out_by
  /// </summary>
  CheckedOutBy,

  /// <summary>
  /// include associated event
  /// </summary>
  Event,

  /// <summary>
  /// include associated event_period
  /// </summary>
  EventPeriod,

  /// <summary>
  /// include associated event_times
  /// </summary>
  EventTimes,

  /// <summary>
  /// include associated locations
  /// </summary>
  Locations,

  /// <summary>
  /// include associated options
  /// </summary>
  Options,

  /// <summary>
  /// include associated person
  /// </summary>
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
  CheckedOutAt,

  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-first_name) to reverse the order
  /// </summary>
  FirstName,

  /// <summary>
  /// prefix with a hyphen (-last_name) to reverse the order
  /// </summary>
  LastName,

  /// <summary>
  /// prefix with a hyphen (-number) to reverse the order
  /// </summary>
  Number,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  UpdatedAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.CheckIn" />.
/// </summary>
public enum CheckInQueryable
{
  /// <summary>
  /// Query on a specific created_at
  /// </summary>
  CreatedAt,

  /// <summary>
  /// Query on a specific security_code
  /// </summary>
  SecurityCode,

  /// <summary>
  /// Query on a specific updated_at
  /// </summary>
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
  Attendee,

  /// <summary>
  /// Filter by checked_out.
  /// </summary>
  CheckedOut,

  /// <summary>
  /// Filter by first_time.
  /// </summary>
  FirstTime,

  /// <summary>
  /// Filter by guest.
  /// </summary>
  Guest,

  /// <summary>
  /// Filter by not_checked_out.
  /// </summary>
  NotCheckedOut,

  /// <summary>
  /// Filter by not_one_time_guest.
  /// </summary>
  NotOneTimeGuest,

  /// <summary>
  /// Filter by one_time_guest.
  /// </summary>
  OneTimeGuest,

  /// <summary>
  /// Filter by regular.
  /// </summary>
  Regular,

  /// <summary>
  /// Filter by volunteer.
  /// </summary>
  Volunteer,

}

