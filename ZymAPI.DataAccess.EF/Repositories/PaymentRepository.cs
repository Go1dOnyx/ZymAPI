using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Account.DataAccess.EF.Context;
using Account.DataAccess.EF.Models;
using Microsoft.EntityFrameworkCore;

namespace Account.DataAccess.EF.Repositories
{
    internal class PaymentRepository: Contract.IPaymentRepository
    {
        private readonly AccountContext _accountContext;
        public PaymentRepository(AccountContext dbContext) 
        {
            _accountContext = dbContext;
        }
        public async Task<Payment> CreatePaymentAsync(Payment payment) 
        {
            await _accountContext.AddAsync(payment);

            _accountContext.SaveChanges();

            _accountContext.Dispose();

            return payment;
        }
        public async Task<Payment> GetPaymentByIdAsync(int payID) 
        {
            Payment? getPayment = await _accountContext.Payments.FindAsync(payID);

            _accountContext.Dispose();

            return getPayment ?? throw new InvalidOperationException("Could not find payment method");
        }
        public async Task<IQueryable<Payment>> GetAllPaymentsByUserIdAsync(Guid userID) 
        {
            var getAllById = await _accountContext.Payments.Where(p => p.UserId == userID).ToListAsync();

            _accountContext.Dispose();

            return getAllById.AsQueryable();
        }
        public async Task<IQueryable<Payment>> GetAllPaymentsAsync() 
        {
            var getAllPayments = await _accountContext.Payments.ToListAsync();

            _accountContext.Dispose();

            return getAllPayments.AsQueryable();
        }
        public async Task<Payment> EditPaymentByIdAsync(Payment payment) 
        {
            Payment? getPayment = await _accountContext.Payments.FindAsync(payment.PaymentId);

            if (getPayment != null) 
            {
                getPayment.UserId = payment.UserId;
                getPayment.CardholderName = payment.CardholderName;
                getPayment.CardNumHash = payment.CardNumHash;
                getPayment.SecHash = payment.SecHash;
                getPayment.ExpirationDate = payment.ExpirationDate;
                getPayment.CardType = payment.CardType;

                _accountContext.SaveChanges();

                _accountContext.Dispose();

                return getPayment;
            }

            throw new InvalidOperationException("Could not find payment");
        }
        public async Task<bool> DeletePaymentByIdAsync(int payID) 
        {
            Payment? getPayment = await _accountContext.Payments.FindAsync(payID);

            if (getPayment != null) 
            {
                _accountContext.Remove(payID);

                _accountContext.SaveChanges();

                _accountContext.Dispose();

                return true;
            }

            return false;
        }
    }
}
