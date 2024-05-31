using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Account.DataAccess.EF.Context;
using Account.DataAccess.EF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Account.DataAccess.EF.Repositories
{
    public class AccountRepository: Contract.IAccountRepository
    {
        private readonly AccountContext _accoutContext;

        public AccountRepository(AccountContext dbContext) 
        {
            _accoutContext = dbContext;
        }

        public async Task<User> CreateAccountAsync(User user) 
        {
            await _accoutContext.AddAsync(user);

            _accoutContext.SaveChanges();

            _accoutContext.Dispose();

            return user;
        }
        public async Task<User> GetAccountByIdAsync(Guid userID) 
        {
            User? getUser = await _accoutContext.Users.FindAsync(userID); //ok if returned as null.

            _accoutContext.Dispose();

            return getUser ?? throw new InvalidOperationException($"User not found.");

        }
        public async Task<IQueryable<User>> GetAllAccountsAsync() 
        {
            var getAllUsers = await _accoutContext.Users.ToListAsync();

            _accoutContext.Dispose();

            return getAllUsers.AsQueryable();
        }
        public async Task<User> EditAccountAsync(User user) 
        {
            User? updateUser = await _accoutContext.Users.FindAsync(user.UserId);

            if (updateUser != null) 
            {
                updateUser.UserName = user.UserName;
                updateUser.Email = user.Email;
                updateUser.PasswordHash = user.PasswordHash;
                updateUser.FirstName = user.FirstName;
                updateUser.MiddleName = user.MiddleName;
                updateUser.LastName = user.LastName;
                updateUser.Telephone = user.Telephone;

                _accoutContext.SaveChanges();

                _accoutContext.Dispose();

                return updateUser;
            }

            throw new InvalidOperationException($"{user.UserName} not found or wrong password");
        }
        public async Task<bool> DeleteAccountAsync(User user) 
        {
            User? delUser = await _accoutContext.Users.FindAsync(user.UserId);

            if (delUser != null) 
            {
                _accoutContext.Remove(delUser);

                _accoutContext.SaveChanges();

                _accoutContext.Dispose();

                return true;
            }

            return false;
        }
    }
}
