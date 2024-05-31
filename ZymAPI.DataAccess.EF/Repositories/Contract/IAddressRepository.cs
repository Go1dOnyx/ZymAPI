using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Account.DataAccess.EF.Models;

namespace Account.DataAccess.EF.Repositories.Contract
{
    public interface IAddressRepository
    {
        Task<Address> CreateAddrAsync(Address addr);

        Task<Address> GetAddrByIdAsync(Address addr);

        Task<IQueryable<Address>> GetAllAddrAsync();

        Task<IQueryable<Address>> GetAllAddrByIdAsync(Guid userID);

        Task<Address> EditAddrAsync(Address addr);

        Task<bool> DeleteAddrAsync(Address addr);
    }
}
