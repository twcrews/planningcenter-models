namespace Crews.PlanningCenter.Models.Services.V2018_11_01.Parameters;

/// <summary>
/// Orderable attributes for <see cref="Entities.Song" />.
/// </summary>
public enum SongOrderable
{
  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-last_scheduled_at) to reverse the order
  /// </summary>
  [JsonApiName("last_scheduled_at")]
  LastScheduledAt,

  /// <summary>
  /// prefix with a hyphen (-title) to reverse the order
  /// </summary>
  [JsonApiName("title")]
  Title,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  [JsonApiName("updated_at")]
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
  [JsonApiName("author")]
  Author,

  /// <summary>
  /// Query on a specific ccli_number
  /// </summary>
  [JsonApiName("ccli_number")]
  CcliNumber,

  /// <summary>
  /// Query on a specific hidden
  /// </summary>
  [JsonApiName("hidden")]
  Hidden,

  /// <summary>
  /// Query on a specific themes
  /// </summary>
  [JsonApiName("themes")]
  Themes,

  /// <summary>
  /// Query on a specific title
  /// </summary>
  [JsonApiName("title")]
  Title,

}

