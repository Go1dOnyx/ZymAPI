using System;
using System.Collections.Generic;

namespace Account.DataAccess.EF.Models;

public partial class Address
{
    public Guid AddrId { get; set; }

    public Guid UserId { get; set; }

    public string Street { get; set; } = null!;

    public string Apt { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public int ZipCode { get; set; }

    public string Country { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
