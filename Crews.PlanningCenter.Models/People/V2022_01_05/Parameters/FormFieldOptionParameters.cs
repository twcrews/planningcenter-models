namespace Crews.PlanningCenter.Models.People.V2022_01_05.Parameters;

/// <summary>
/// Orderable attributes for <see cref="Entities.FormFieldOption" />.
/// </summary>
public enum FormFieldOptionOrderable
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

