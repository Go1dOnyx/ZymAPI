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

        Task<IQueryable<Payment>> GetAllPayments();

        Task<IQueryable<Payment>> GetAllPaymentsByUserIDAsync(int userID); //payID or userID?

        Task<Payment> EditPaymentAsync(int payID);

        Task<bool> DeletePaymentAsync(int payID);
    }
}
