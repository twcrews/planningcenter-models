namespace Crews.PlanningCenter.Models.People.V2022_07_14.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.FormField" />.
/// </summary>
public enum FormFieldIncludable
{
  /// <summary>
  /// include associated options
  /// </summary>
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
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-sequence) to reverse the order
  /// </summary>
  Sequence,

  /// <summary>
  /// prefix with a hyphen (-updated_at) to reverse the order
  /// </summary>
  UpdatedAt,

}

