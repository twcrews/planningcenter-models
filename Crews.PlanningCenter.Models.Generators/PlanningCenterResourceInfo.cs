namespace Crews.PlanningCenter.Models.Generators;

public record PlanningCenterResourceInfo
{
	public required string ID { get; set; }
	public required string Name { get; set; }
	public required string Description { get; set; }
}
