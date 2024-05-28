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
}
