﻿using Domain.Contracts;

namespace Domain.Entities;

public class User : Entity<Guid>
{
    public string Email { get; set; }
    public string UserName { get; set; }
    public string PasswordHash { get; set; }
    public bool IsVerified { get; set; }
}