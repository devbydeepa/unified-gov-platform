namespace WorkflowService.Domain.Entities;

public class ApplicationWorkflow
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string CurrentState { get; set; } = "DRAFT"; // Initial state
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
