namespace Empower.Domain.Entities.Shared;

public abstract class AuditableEntity<T> : Entity<T>
{
    public T? CreateBy { get; set; }
    public DateTimeOffset? CreateAt { get; set; }
    public T? UpdatedBy { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}
