namespace Application.Repository;

public interface IUnitOfWork : IDisposable
{
    IUserRepository UserRepository { get; }
    IUserRoleRepository UserRoleRepository { get; }
    IRolePermissionRepository RolePermissionRepository { get; }
    
    Task<int> CommitAsync(CancellationToken cancellationToken);

    Task RollbackAsync();
}