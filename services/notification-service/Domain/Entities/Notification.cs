namespace NotificationService.Domain.Entities;

public class Notification
{
    public Guid Id { get; set; }
    public string Recipient { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
    public DateTime SentAt { get; set; }
    public bool IsRead { get; set; }
}
