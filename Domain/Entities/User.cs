namespace Domain.Entities;

public record User(Guid Id, string Email, string UserName, string PasswordHash, IEnumerable<UserRole> Roles);