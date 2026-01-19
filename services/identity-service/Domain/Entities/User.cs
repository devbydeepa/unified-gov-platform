namespace IdentityService.Domain.Entities;

public class User
{
    public Guid Id { get; set; }
    public string NationalId { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Role { get; set; } = "Citizen";
    public DateTime CreatedAt { get; set; }
}
