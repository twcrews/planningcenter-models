namespace Crews.PlanningCenter.Models.CheckIns.V2018_08_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Person" />.
/// </summary>
public enum PersonIncludable
{
  /// <summary>
  /// include associated organization
  /// </summary>
  Organization,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.Person" />.
/// </summary>
public enum PersonOrderable
{
  /// <summary>
  /// prefix with a hyphen (-check_in_count) to reverse the order
  /// </summary>
  CheckInCount,

  /// <summary>
  /// prefix with a hyphen (-first_name) to reverse the order
  /// </summary>
  FirstName,

  /// <summary>
  /// prefix with a hyphen (-last_checked_in_at) to reverse the order
  /// </summary>
  LastCheckedInAt,

  /// <summary>
  /// prefix with a hyphen (-last_name) to reverse the order
  /// </summary>
  LastName,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Person" />.
/// </summary>
public enum PersonQueryable
{
  /// <summary>
  /// Query on a specific headcounter
  /// </summary>
  Headcounter,

  /// <summary>
  /// Query on a specific ignore_filters
  /// </summary>
  IgnoreFilters,

  /// <summary>
  /// Query on a specific permission
  /// </summary>
  Permission,

  /// <summary>
  /// Search by person name (first, last, combination)
  /// </summary>
  SearchName,

}

