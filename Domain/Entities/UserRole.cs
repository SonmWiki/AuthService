namespace Domain.Entities;

public record UserRole(Guid Id, string Name, int Priority, IEnumerable<RolePermission> Permissions);