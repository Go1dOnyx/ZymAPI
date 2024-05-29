using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Account.DataAccess.EF.Models;

namespace Account.DataAccess.EF.Repositories.Contract
{
    internal interface IAdminRepository
    {
        Task<Admin> CreateAdminAsync(Admin user);

        Task<Admin> GetAdminByIdAsync(int adminID);

        Task<IQueryable<Admin>> GetAllAdminsAsync();

        Task<Admin> EditAdminAsync(int adminID);

        Task<bool> DeleteAdminAsync(int adminID);
    }
}
