using System.Linq.Expressions;
using Domain.Contracts;

namespace Application.Repository;

public interface IRepositoryAsync<T, in TId> where T : class, IEntity<TId>
{
    Task<T> GetByIdAsync(TId id);
    Task<IEnumerable<T>> GetAllAsync();
    Task<IQueryable<T>> Find(Expression<Func<T, bool>> expression);
    Task<T> CreateAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
}