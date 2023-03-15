namespace Application.Repository;

public interface IUnitOfWork
{
    Task CommitAsync(CancellationToken cancellationToken);

    Task RollbackAsync();
}