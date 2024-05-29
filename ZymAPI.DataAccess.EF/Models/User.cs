using System;
using System.Collections.Generic;

namespace Account.DataAccess.EF.Models;

public partial class User
{
    public Guid UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string MiddleName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Telephone { get; set; } = null!;

    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public User(Guid userID, string userName, string email, string password, string fName, string mName, string lName, string phone) 
    {
        UserId = userID;
        UserName = userName;
        Email = email;
        PasswordHash = password;
        FirstName = fName;
        MiddleName = mName;
        LastName = lName;
        Telephone = phone;
    }
    public User() { }
}
