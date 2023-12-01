namespace Empower.Domain.Contracts.Repositories.Shared
{
    public interface IGenericWritableRepository<TKey, TEntity>
    {
        Task CreateAsync(TEntity entity, CancellationToken cancellationToken = default);
        Task DeleteAsync(TKey id, CancellationToken cancellationToken = default);
        Task DestroyAsync(TKey id, CancellationToken cancellationToken = default);
        Task UpdateAsync(TKey id, TEntity entity, CancellationToken cancellationToken = default);
    }
}
