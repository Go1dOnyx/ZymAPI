using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Account.DataAccess.EF.Models;

namespace Account.DataAccess.EF.Repositories.Contract
{
    public interface IAccountRepository
    {
            Task<User> CreateAccountAsync(User user);

            Task<User> GetAccountByIdAsync(int userID);

            Task<IQueryable<User>> GetAllAccountsAsync();

            Task<User> EditAccountAsync(int userID);

            Task<bool> DeleteAccountAsync(int userID);
    }
}
