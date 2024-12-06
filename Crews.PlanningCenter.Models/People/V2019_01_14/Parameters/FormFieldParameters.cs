namespace Crews.PlanningCenter.Models.People.V2019_01_14.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.FormField" />.
/// </summary>
public enum FormFieldIncludable
{
  /// <summary>
  /// include associated options
  /// </summary>
  [JsonApiName("options")]
  Options,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.FormField" />.
/// </summary>
public enum FormFieldOrderable
{
  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-sequence) to reverse the order
  /// </summary>
  [JsonApiName("sequence")]
  Sequence,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  [JsonApiName("updated_at")]
  UpdatedAt,

}

