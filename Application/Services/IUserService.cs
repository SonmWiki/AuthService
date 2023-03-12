namespace Application.Services;

public interface IUserService : IService
{
    Task CreateUserAsync();
    Task LogInAsync();
    Task RefreshTokenAsync();
    Task LogOffAsync();
}