namespace Crews.PlanningCenter.Models.Services.V2018_11_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.ServiceType" />.
/// </summary>
public enum ServiceTypeIncludable
{
  /// <summary>
  /// include associated time_preference_options
  /// </summary>
  TimePreferenceOptions,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.ServiceType" />.
/// </summary>
public enum ServiceTypeOrderable
{
  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
  Name,

  /// <summary>
  /// prefix with a hyphen (-sequence) to reverse the order
  /// </summary>
  Sequence,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.ServiceType" />.
/// </summary>
public enum ServiceTypeQueryable
{
  /// <summary>
  /// Query on a specific id
  /// </summary>
  Id,

  /// <summary>
  /// Query on a specific name
  /// </summary>
  Name,

}

/// <summary>
/// Filterable attributes for <see cref="Entities.ServiceType" />.
/// </summary>
public enum ServiceTypeFilterable
{
  /// <summary>
  /// Filter by no_parent.
  /// </summary>
  NoParent,

}

