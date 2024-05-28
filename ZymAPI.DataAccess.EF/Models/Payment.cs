using System;
using System.Collections.Generic;

namespace Account.DataAccess.EF.Models;

public partial class Payment
{
    public int PaymentId { get; set; }

    public Guid UserId { get; set; }

    public string CardholderName { get; set; } = null!;

    public string CardNumHash { get; set; } = null!;

    public string SecHash { get; set; } = null!;

    public string ExpirationDate { get; set; } = null!;

    public string CardType { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
