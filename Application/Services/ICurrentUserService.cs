namespace Application.Services;

public interface ICurrentUserService : IService
{
    Guid UserId { get; }
}