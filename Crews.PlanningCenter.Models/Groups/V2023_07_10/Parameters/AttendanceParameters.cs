namespace Crews.PlanningCenter.Models.Groups.V2023_07_10.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Attendance" />.
/// </summary>
public enum AttendanceIncludable
{
  /// <summary>
  /// include associated person
  /// </summary>
  Person,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.Attendance" />.
/// </summary>
public enum AttendanceOrderable
{
  /// <summary>
  /// prefix with a hyphen (-first_name) to reverse the order
  /// </summary>
  FirstName,

  /// <summary>
  /// prefix with a hyphen (-last_name) to reverse the order
  /// </summary>
  LastName,

  /// <summary>
  /// prefix with a hyphen (-role) to reverse the order
  /// </summary>
  Role,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Attendance" />.
/// </summary>
public enum AttendanceQueryable
{
  /// <summary>
  /// Query on a specific role
  /// 
  /// Possible values: <c>member</c>, <c>leader</c>, <c>visitor</c>, or <c>applicant</c>
  /// </summary>
  Role,

}

