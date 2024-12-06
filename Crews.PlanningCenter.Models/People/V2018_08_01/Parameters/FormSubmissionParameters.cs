namespace Crews.PlanningCenter.Models.People.V2018_08_01.Parameters;

/// <summary>
/// Includable resources for <see cref="Entities.FormSubmission" />.
/// </summary>
public enum FormSubmissionIncludable
{
  /// <summary>
  /// include associated form
  /// </summary>
  [JsonApiName("form")]
  Form,

  /// <summary>
  /// include associated form_fields
  /// </summary>
  [JsonApiName("form_fields")]
  FormFields,

  /// <summary>
  /// include associated form_submission_values
  /// </summary>
  [JsonApiName("form_submission_values")]
  FormSubmissionValues,

  /// <summary>
  /// include associated person
  /// </summary>
  [JsonApiName("person")]
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
  [JsonApiName("created_at")]
  CreatedAt,

  /// <summary>
  /// prefix with a hyphen (-person.first_name) to reverse the order
  /// </summary>
  [JsonApiName("person.first_name")]
  PersonFirstName,

  /// <summary>
  /// prefix with a hyphen (-person.last_name) to reverse the order
  /// </summary>
  [JsonApiName("person.last_name")]
  PersonLastName,

}

