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

    public Address(Guid addrID, Guid userID, string street, string apt, string state, int zip, string country) 
    {
        AddrId = addrID;
        UserId = userID;
        Street = street;
        Apt = apt;
        State = state;
        ZipCode = zip;
        Country = country;
    }
    public Address() { }
}
