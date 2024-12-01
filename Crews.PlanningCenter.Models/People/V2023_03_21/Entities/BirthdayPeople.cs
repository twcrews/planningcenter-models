using System.Text.Json;

namespace Crews.PlanningCenter.Models.People.V2023_03_21.Entities;

/// <summary>
/// Returns upcoming birthdays for the organization.
/// 
/// Note: This endpoint will always only return the first 15 people having a birthday in the next 30 days, ordered by birthday, ascending.
/// 
/// </summary>
public record BirthdayPeople
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Id { get; init; }

}