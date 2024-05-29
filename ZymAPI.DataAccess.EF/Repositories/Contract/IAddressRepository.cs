using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Account.DataAccess.EF.Models;

namespace Account.DataAccess.EF.Repositories.Contract
{
    internal interface IAddressRepository
    {
        Task<Address> CreateAddrAsync(Address addr);

        Task<Address> GetAddrByIdAsync(int addrID);

        Task<IQueryable<Address>> GetAllAddrAsync();

        Task<Address> EditAddrAsync(int addrID);

        Task<bool> DeleteAddrAsync(int addrID);
    }
}
