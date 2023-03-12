namespace Application.Services;

public interface IPasswordHasher : IService
{
    string GetHash(string password);
}