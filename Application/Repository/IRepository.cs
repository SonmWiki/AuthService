using System.Linq.Expressions;
using Domain.Contracts;

namespace Application.Repository;

public interface IRepository<T> where T : IEntity
{
    IQueryable<T> Entities { get; }
    Task<IQueryable<T>> GetByConditionAsync(Expression<Func<T, bool>> expression);
    Task<ICollection<T>> GetAllAsync();
    Task<T> CreateAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
}