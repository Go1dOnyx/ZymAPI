using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using System;
using System.Collections.Generic;

namespace Account.DataAccess.EF.Models;

public partial class Admin
{
    public Guid AdminId { get; set; }

    public string AdminUserName { get; set; } = null!;

    public string AdminEmail { get; set; } = null!;

    public string AdminPasswordHash { get; set; } = null!;

    public int AdminRole { get; set; }

    public Admin(Guid adminID, string adminUser, string adminEmail, string passHash, int adminRole) 
    {
        AdminId = adminID;
        AdminUserName = adminUser;
        AdminEmail = adminEmail;
        AdminPasswordHash = passHash;
        AdminRole = adminRole;
    }
    public Admin() { }
}
