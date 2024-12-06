namespace Crews.PlanningCenter.Models.Services.V2018_08_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.ServiceType" />.
/// </summary>
public enum ServiceTypeIncludable
{
  /// <summary>
  /// include associated time_preference_options
  /// </summary>
  [JsonApiName("time_preference_options")]
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
  [JsonApiName("name")]
  Name,

  /// <summary>
  /// prefix with a hyphen (-sequence) to reverse the order
  /// </summary>
  [JsonApiName("sequence")]
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
  [JsonApiName("id")]
  Id,

  /// <summary>
  /// Query on a specific name
  /// </summary>
  [JsonApiName("name")]
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
  [JsonApiName("no_parent")]
  NoParent,

}

