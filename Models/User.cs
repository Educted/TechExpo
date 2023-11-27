﻿using System;
using System.Collections.Generic;

namespace TechSPO.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Username { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? FullName { get; set; }

    public DateTime? RegistrationDate { get; set; }
}
