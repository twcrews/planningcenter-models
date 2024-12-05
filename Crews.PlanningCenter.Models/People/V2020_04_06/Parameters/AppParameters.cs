namespace Crews.PlanningCenter.Models.People.V2020_04_06.Parameters;

/// <summary>
/// Orderable attributes for <see cref="Entities.App" />.
/// </summary>
public enum AppOrderable
{
  /// <summary>
  /// prefix with a hyphen (-name) to reverse the order
  /// </summary>
  Name,

  /// <summary>
  /// prefix with a hyphen (-url) to reverse the order
  /// </summary>
  Url,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.App" />.
/// </summary>
public enum AppQueryable
{
  /// <summary>
  /// Query on a specific name
  /// </summary>
  Name,

  /// <summary>
  /// Query on a specific url
  /// </summary>
  Url,

}

