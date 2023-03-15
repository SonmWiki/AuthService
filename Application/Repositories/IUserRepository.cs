using Domain.Entities;

namespace Application.Repository;

public interface IUserRepository : IRepositoryAsync<User, Guid>
{
}