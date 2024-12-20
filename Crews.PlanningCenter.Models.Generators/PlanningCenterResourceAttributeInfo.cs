namespace Crews.PlanningCenter.Models.Generators;

public record PlanningCenterResourceAttributeInfo
{
	public required string Name { get; init; }
	public required string Type { get; init; }
	public required string ClrTypeName { get; init; }
	public required string Description { get; init; }
}
