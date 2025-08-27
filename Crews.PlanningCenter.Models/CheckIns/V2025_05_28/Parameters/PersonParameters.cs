namespace Crews.PlanningCenter.Models.CheckIns.V2025_05_28.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.Person" />.
/// </summary>
public enum PersonIncludable
{
  /// <summary>
  /// include associated organization
  /// </summary>
  [JsonApiName("organization")]
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
  [JsonApiName("check_in_count")]
  CheckInCount,

  /// <summary>
  /// prefix with a hyphen (-first_name) to reverse the order
  /// </summary>
  [JsonApiName("first_name")]
  FirstName,

  /// <summary>
  /// prefix with a hyphen (-last_checked_in_at) to reverse the order
  /// </summary>
  [JsonApiName("last_checked_in_at")]
  LastCheckedInAt,

  /// <summary>
  /// prefix with a hyphen (-last_name) to reverse the order
  /// </summary>
  [JsonApiName("last_name")]
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
  [JsonApiName("headcounter")]
  Headcounter,

  /// <summary>
  /// Query on a specific ignore_filters
  /// </summary>
  [JsonApiName("ignore_filters")]
  IgnoreFilters,

  /// <summary>
  /// Query on a specific permission
  /// </summary>
  [JsonApiName("permission")]
  Permission,

  /// <summary>
  /// Search by person name (first, last, combination)
  /// </summary>
  [JsonApiName("search_name")]
  SearchName,

}

