namespace Crews.PlanningCenter.Models.Calendar.V2018_08_01.Entities;

/// <summary>
/// A question to answer when requesting to book a room or resource.
/// </summary>
public record ResourceQuestion
{
  /// <summary>
  /// Unique identifier for the question
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// UTC time at which the question was created
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Possible values:
  /// - <c>dropdown</c>: predefined list of choices as an answer
  /// - <c>paragraph</c>: expected answer is a paragraph
  /// - <c>text</c>: expected answer is a sentence
  /// - <c>yesno</c>: expected answer is 'Yes' or 'No'
  /// 
  /// - <c>section_header</c>: used to separate questions in the UI, no expected answer
  /// </summary>
  public string? Kind { get; init; }

  /// <summary>
  /// UTC time at which the question was updated
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// If <c>kind</c> is <c>dropdown</c>, represents a string of dropdown choices
  /// separated by the <c>|</c> character
  /// </summary>
  public string? Choices { get; init; }

  /// <summary>
  /// Optional description of the question
  /// </summary>
  public string? Description { get; init; }

  /// <summary>
  /// If <c>kind</c> is <c>dropdown</c>,
  /// <c>true</c> indicates that more than one selection is permitted
  /// </summary>
  public bool? MultipleSelect { get; init; }

  /// <summary>
  /// - <c>true</c> indicates answering the question is not required when booking
  /// - <c>false</c> indicates answering the question is required when booking
  /// </summary>
  public bool? Optional { get; init; }

  /// <summary>
  /// Position of question in list in the UI
  /// </summary>
  public int? Position { get; init; }

  /// <summary>
  /// The question to be answered
  /// </summary>
  public string? Question { get; init; }

}
