namespace Crews.PlanningCenter.Models.People.V2018_08_01.Entities;

/// <summary>
/// An app is one of the handful of apps that Planning Center offers that organizations can subscribe to, e.g. Services, Registrations, etc.
/// </summary>
public record App
{
  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? ID { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Name { get; init; }

  /// <summary>
  /// Planning Center does not provide a description for this attribute.
  /// </summary>
  public string? Url { get; init; }

}
