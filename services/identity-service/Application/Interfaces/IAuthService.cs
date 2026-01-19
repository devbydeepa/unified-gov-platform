namespace IdentityService.Application.Interfaces;

public interface IAuthService
{
    Task<string> LoginAsync(string nationalId);
}
