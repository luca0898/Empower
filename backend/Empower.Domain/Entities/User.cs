using Empower.Domain.Entities.Shared;

namespace Empower.Domain.Entities;

public class User : Entity<Guid>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName { get { return FirstName + LastName; } }
    public string Email { get; set; }
    public string JobTitle { get; set; }
    public string AvatarUrl { get; set; }
    public string PasswordHash { get; set; }
}
