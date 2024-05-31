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
    internal class AdminRepository: Contract.IAdminRepository
    {
        private readonly AccountContext _accountContext;
        public AdminRepository(AccountContext dbContext) 
        {
            _accountContext = dbContext;
        }
        public async Task<Admin> CreateAdminAsync(Admin admin) 
        {
            await _accountContext.AddAsync(admin);

            _accountContext.SaveChanges();

            _accountContext.Dispose();

            return admin;
        }
        public async Task<Admin> GetAdminByIdAsync(Guid adminID) 
        {
            Admin? getAdmin = await _accountContext.Admins.FindAsync(adminID);

            _accountContext.Dispose();

            return getAdmin ?? throw new InvalidOperationException("Could not find admin");
        }
        public async Task<IQueryable<Admin>> GetAllAdminsAsync() 
        {
            var getAll = await _accountContext.Admins.ToListAsync();

            _accountContext.Dispose();

            return getAll.AsQueryable();
        }
        public async Task<Admin> EditAdminByIdAsync(Admin admin) 
        {
            Admin? updateAdmin = await _accountContext.Admins.FindAsync(admin.AdminId);

            if (updateAdmin != null) 
            {
                updateAdmin.AdminUserName = admin.AdminUserName;
                updateAdmin.AdminEmail = admin.AdminEmail;
                updateAdmin.AdminPasswordHash = admin.AdminPasswordHash;
                updateAdmin.AdminRole = admin.AdminRole;

                _accountContext.SaveChanges();

                _accountContext.Dispose();

                return updateAdmin;
            }

            throw new InvalidOperationException("Could not find admin or make changes");
        }
        public async Task<bool> DeleteAdminByIdAsync(Guid adminID) 
        {
            Admin? getAdmin = await _accountContext.Admins.FindAsync(adminID);

            if (getAdmin != null) 
            {
                _accountContext.Remove(getAdmin);

                _accountContext.SaveChanges();

                _accountContext.Dispose();

                return true;
            }

            return false;
        }
    }
}
