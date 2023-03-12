namespace Application.Repository;

public interface IUnitOfWork : IDisposable
{
    IUserRepository UserRepository { get; }
    
    Task<int> CommitAsync(CancellationToken cancellationToken);

    Task RollbackAsync();
}