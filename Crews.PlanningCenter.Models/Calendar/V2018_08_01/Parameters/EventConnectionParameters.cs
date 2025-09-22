namespace Crews.PlanningCenter.Models.Calendar.V2018_08_01.Parameters;

/// <summary>
/// Queryable attributes for <see cref="Entities.EventConnection" />.
/// </summary>
public enum EventConnectionQueryable
{
  /// <summary>
  /// Query on a specific connected_to_id
  /// </summary>
  [JsonApiName("connected_to_id")]
  ConnectedToId,

  /// <summary>
  /// Query on a specific product_name
  /// </summary>
  [JsonApiName("product_name")]
  ProductName,

  /// <summary>
  /// Query on a specific promoted
  /// </summary>
  [JsonApiName("promoted")]
  Promoted,

}

