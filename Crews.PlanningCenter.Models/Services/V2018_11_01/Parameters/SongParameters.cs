namespace Crews.PlanningCenter.Models.Services.V2018_11_01.Parameters;

/// <summary>
/// Orderable attributes for <see cref="Entities.Song" />.
/// </summary>
public enum SongOrderable
{
  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-last_scheduled_at) to reverse the order
  /// </summary>
  LastScheduledAt,

  /// <summary>
  /// prefix with a hyphen (-title) to reverse the order
  /// </summary>
  Title,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  UpdatedAt,

}

/// <summary>
/// Queryable attributes for <see cref="Entities.Song" />.
/// </summary>
public enum SongQueryable
{
  /// <summary>
  /// Query on a specific author
  /// </summary>
  Author,

  /// <summary>
  /// Query on a specific ccli_number
  /// </summary>
  CcliNumber,

  /// <summary>
  /// Query on a specific hidden
  /// </summary>
  Hidden,

  /// <summary>
  /// Query on a specific themes
  /// </summary>
  Themes,

  /// <summary>
  /// Query on a specific title
  /// </summary>
  Title,

}

