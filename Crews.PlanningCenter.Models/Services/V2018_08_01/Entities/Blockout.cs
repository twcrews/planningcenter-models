namespace Crews.PlanningCenter.Models.Services.V2018_08_01.Entities;

/// <summary>
/// An object representing a blockout date, and an optional recurrence pattern
/// </summary>
public record Blockout
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Description { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? GroupIdentifier { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? OrganizationName { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Reason { get; init; }

  /// <summary>
  /// Possible values:
  /// 
  /// - no_repeat
  /// 
  /// - every_1
  /// 
  /// - every_2
  /// 
  /// - every_3
  /// 
  /// - every_4
  /// 
  /// - every_5
  /// 
  /// - every_6
  /// 
  /// - every_7
  /// 
  /// - every_8
  /// </summary>
  public string? RepeatFrequency { get; init; }

  /// <summary>
  /// Possible values:
  /// 
  /// - exact_day_of_month
  /// 
  /// - week_of_month_1
  /// 
  /// - week_of_month_2
  /// 
  /// - week_of_month_3
  /// 
  /// - week_of_month_4
  /// 
  /// - week_of_month_last
  /// </summary>
  public string? RepeatInterval { get; init; }

  /// <summary>
  /// Possible values:
  /// 
  /// - daily
  /// 
  /// - weekly
  /// 
  /// - monthly
  /// 
  /// - yearly
  /// </summary>
  public string? RepeatPeriod { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Settings { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? TimeZone { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? CreatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? UpdatedAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateOnly? RepeatUntil { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? StartsAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public DateTime? EndsAt { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public bool? Share { get; init; }

}
