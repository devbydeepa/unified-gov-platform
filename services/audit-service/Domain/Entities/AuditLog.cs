namespace AuditService.Domain.Entities;

public class AuditLog
{
    public Guid Id { get; set; }
    public string UserId { get; set; } = string.Empty;
    public string Action { get; set; } = string.Empty;
    public string Entity { get; set; } = string.Empty;
    public DateTime Timestamp { get; set; }
    public string Remarks { get; set; } = string.Empty;
}
