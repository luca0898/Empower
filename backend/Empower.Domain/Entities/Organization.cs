using Empower.Domain.Entities.Shared;

namespace Empower.Domain.Entities
{
    public class Organization : AuditableEntity<Guid>
    {
        public string? Name { get; set; }
        public string? ImageUrl { get; set; }

        public Guid? AdminId { get; set; }
        public User? Admin { get; set; }

        public IEnumerable<User>? Managers { get; set; }
        public IEnumerable<User>? Users { get; set; }
    }
}
