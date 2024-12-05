namespace Crews.PlanningCenter.Models.People.V2023_02_15.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.FormSubmission" />.
/// </summary>
public enum FormSubmissionIncludable
{
  /// <summary>
  /// include associated form
  /// </summary>
  Form,

  /// <summary>
  /// include associated form_fields
  /// </summary>
  FormFields,

  /// <summary>
  /// include associated form_submission_values
  /// </summary>
  FormSubmissionValues,

  /// <summary>
  /// include associated person
  /// </summary>
  Person,

}

/// <summary>
/// Orderable attributes for <see cref="Entities.FormSubmission" />.
/// </summary>
public enum FormSubmissionOrderable
{
  /// <summary>
  /// prefix with a hyphen (-created_at) to reverse the order
  /// </summary>
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-person.first_name) to reverse the order
  /// </summary>
  Person.firstName,

  /// <summary>
  /// prefix with a hyphen (-person.last_name) to reverse the order
  /// </summary>
  Person.lastName,

}

