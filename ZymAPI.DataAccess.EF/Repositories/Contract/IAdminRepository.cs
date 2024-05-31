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
        Task<Admin> CreateAdminAsync(Admin admin);

        Task<Admin> GetAdminByIdAsync(Guid adminID);

        Task<IQueryable<Admin>> GetAllAdminsAsync();

        Task<Admin> EditAdminByIdAsync(Admin admin);

        Task<bool> DeleteAdminByIdAsync(Guid Admin);
    }
}
