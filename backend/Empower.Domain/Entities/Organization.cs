using Empower.Domain.Entities.Shared;

namespace Empower.Domain.Entities
{
    public class Organization : AuditableEntity<Guid>
    {
        public string? Name { get; set; }
        public string? ImageUrl { get; set; }
    }
}
