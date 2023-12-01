using System.Linq.Expressions;

namespace Empower.Domain.Contracts.Repositories.Shared;

public interface IGenericReadableRepository<TKey, TEntity>
{
    Task<int> CountAsync();
    Task<IEnumerable<TEntity>> FindAllAsync(CancellationToken cancellationToken = default);
    Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> filter, CancellationToken cancellationToken = default);
    Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> filter, int page = 1, int pageSize = 20, CancellationToken cancellationToken = default);
    Task<IEnumerable<TEntity>> FindByIdAsync(TKey id, CancellationToken cancellationToken = default);
}
