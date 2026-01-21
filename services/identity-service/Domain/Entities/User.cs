namespace IdentityService.Domain.Entities;

public class User
{
    public Guid Id { get; set; }
    public string NationalId { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Role { get; set; } = "Citizen";
    public bool IsActive { get; set; } = true;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    // public string PasswordHash { get; set; } = null!; // Phase 6
}
