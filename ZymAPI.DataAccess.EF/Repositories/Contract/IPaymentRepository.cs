using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Account.DataAccess.EF.Models;

namespace Account.DataAccess.EF.Repositories.Contract
{
    internal interface IPaymentRepository
    {
        Task<Payment> CreatePaymentAsync(Payment pay);

        Task<Payment> GetPaymentByIdAsync(int payID);

        Task<IQueryable<Payment>> GetAllPaymentsAsync();

        Task<IQueryable<Payment>> GetAllPaymentsByUserIdAsync(Guid userID); //payID or userID?

        Task<Payment> EditPaymentByIdAsync(Payment pay);

        Task<bool> DeletePaymentByIdAsync(int payID);
    }
}
