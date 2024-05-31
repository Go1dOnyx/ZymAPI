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
    public class AddressRepository: Contract.IAddressRepository
    {
        private readonly AccountContext _accountContext;

        public AddressRepository(AccountContext dbContext) 
        {
            _accountContext = dbContext;
        }
        public async Task<Address> CreateAddrAsync(Address addr) 
        {
            if (addr != null) 
            {
                await _accountContext.AddAsync(addr);

                _accountContext.SaveChanges();

                _accountContext.Dispose();

                return addr;
            }
            
            throw new InvalidOperationException("Could not create address");

        }
        public async Task<Address> GetAddrByIdAsync(Address addr) 
        {
            Address? getAddr = await _accountContext.Addresses.FindAsync(addr.AddrId);

            _accountContext?.Dispose();

            return getAddr ?? throw new InvalidOperationException("Cannot find address");
        }
        public async Task<IQueryable<Address>> GetAllAddrByIdAsync(Guid userID) 
        {
            var getAllById = await _accountContext.Addresses.Where(a => a.UserId == userID).ToListAsync();

            _accountContext.Dispose();
            
            return getAllById.AsQueryable();
        }
        public async Task<IQueryable<Address>> GetAllAddrAsync() 
        {
            var getAllAddr = await _accountContext.Addresses.ToListAsync();

            _accountContext.Dispose();

            return getAllAddr.AsQueryable();
        }
        public async Task<Address> EditAddrAsync(Address addr) 
        {
            Address? updateAddr = await _accountContext.Addresses.FindAsync(addr.AddrId);

            if (updateAddr != null) 
            {
                updateAddr.UserId = addr.UserId;
                updateAddr.Street = addr.Street;
                updateAddr.Apt = addr.Apt;
                updateAddr.City = addr.City;
                updateAddr.State = addr.State;
                updateAddr.Country = addr.Country;

                _accountContext.SaveChanges();

                _accountContext.Dispose();

                return updateAddr;
            }

            throw new InvalidOperationException($"Could update address");
        }
        public async Task<bool> DeleteAddrAsync(Address addr) 
        {
            Address? getAddress = await _accountContext.Addresses.FindAsync(addr.AddrId);

            if (getAddress != null) 
            {
                _accountContext.Remove(getAddress);

                _accountContext.SaveChanges();

                _accountContext.Dispose();

                return true;
            }

            return false;
        }
    }
}
