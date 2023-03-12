using System.Collections;
using Domain.Contracts;

namespace Domain.Entities;

public class UserRole : Entity<Guid>
{
    public string Name { get; set; }
    public int Priority { get; set; }
    public virtual ICollection<RolePermission> Permissions { get; set; }

}