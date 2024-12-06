namespace Crews.PlanningCenter.Models.People.V2022_01_28.Parameters;

/// <summary>
/// Orderable attributes for <see cref="Entities.ListResult" />.
/// </summary>
public enum ListResultOrderable
{
  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

}

