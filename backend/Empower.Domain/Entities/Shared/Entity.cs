namespace Empower.Domain.Entities.Shared;

public abstract class Entity<T> : Entity
{
    public T? Id { get; set; }
}

public abstract class Entity
{
    public bool Deleted { get; set; }
}